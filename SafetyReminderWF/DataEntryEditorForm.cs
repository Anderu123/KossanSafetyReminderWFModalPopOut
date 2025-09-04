using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafetyReminderWF
{
    public partial class DataEntryEditorForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Compliance Model { get; set; }
        private BindingList<Compliance> _items;

        public DataEntryEditorForm(Compliance existing = null)
        {
            InitializeComponent();
            this.UseWaitCursor = false;
            void ClearWait(Control p) { p.UseWaitCursor = false; foreach (Control c in p.Controls) ClearWait(c); }
            ClearWait(this);
            Application.UseWaitCursor = false;
            Cursor.Current = Cursors.Default;


            Text = existing == null ? "Add Compliance" : "Edit Compliance";
            Model = existing ?? new Compliance();

            //Load model -> controls
            txtAssess.Text = Model.Assessment ?? "";
            numericUpDown1.Value = Model.Frequency.GetValueOrDefault(0);
            numericUpDown2.Value = (decimal)Model.Fee.GetValueOrDefault(0);
            checkBox1.Checked = Model.ReminderSent;
            txtRemark.Text = Model.Remark;


            //Nullable date pickers
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.Checked = Model.CurrentDT.HasValue;
            if (Model.CurrentDT.HasValue)
            {
                dateTimePicker1.Value = Model.CurrentDT.Value;
            }

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2.ShowCheckBox = true;
            dateTimePicker2.Checked = Model.UpComingDT.HasValue;
            if (Model.UpComingDT.HasValue) dateTimePicker2.Value = Model.UpComingDT.Value;

            void syncBlank(DateTimePicker dtp)
            {
                dtp.CustomFormat = dtp.Checked ? "dd/MM/yyyy" : "";
            }
            syncBlank(dateTimePicker1); syncBlank(dateTimePicker2);
            dateTimePicker1.ValueChanged += (_, __) => syncBlank(dateTimePicker1);
            dateTimePicker2.ValueChanged += (_, __) => syncBlank(dateTimePicker2);

            //ok button commits controls -> model
            this.AcceptButton = OKButton;
            this.CancelButton = CancelButton;
            //this.AcceptButton = new Button { DialogResult = DialogResult.OK };
            //this.CancelButton = new Button { DialogResult = DialogResult.Cancel };
            // OKButton_Click += OKButton_Click;

        }
        public bool SaveBackFromControls()
        {
            if (string.IsNullOrWhiteSpace(txtAssess.Text))
                throw new InvalidOperationException("Assessment cannot be blank.");
         

            Model.Assessment = txtAssess.Text.Trim();
            Model.Frequency = (int?)(numericUpDown1.Value == 0 ? null : (int)numericUpDown1.Value);
            Model.CurrentDT = dateTimePicker1.Checked ? dateTimePicker1.Value : (DateTime?)null;
            Model.UpComingDT = dateTimePicker2.Checked ? dateTimePicker2.Value : (DateTime?)null;
            Model.Fee = (decimal?)(numericUpDown2.Value == 0 ? null : numericUpDown2.Value);
            Model.ReminderSent = checkBox1.Checked;
            Model.Remark = string.IsNullOrWhiteSpace(txtRemark.Text) ? null : txtRemark.Text.Trim();
            return true;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveBackFromControls();                    // controls -> Model
                this.DialogResult = DialogResult.OK;       // (if the OK button already has DialogResult=OK, this is harmless)
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;     // keep dialog open
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
