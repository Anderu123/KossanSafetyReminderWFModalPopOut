using KossanSafetyRemnder;
using System.ComponentModel;
using System.Windows.Forms;

namespace SafetyReminderWF
{
    public partial class DataEntryForm : Form
    {
        public BindingList<Compliance> _items = new();
        private Compliance? CurrentItem
        {
            get
            {
                // 1) Try BindingSource (if present)
                if (bindingSource1 != null && bindingSource1.Current is Compliance fromBs)
                    return fromBs;

                // 2) Try the grid’s current/selected row
                var row = ReminderGridView.CurrentRow
                          ?? (ReminderGridView.SelectedRows.Count > 0 ? ReminderGridView.SelectedRows[0] : null);
                return row?.DataBoundItem as Compliance;
            }
        }


        public DataEntryForm()
        {
            InitializeComponent();
            _items = new BindingList<Compliance>();
            ReminderGridView.DataSource = _items;
            ReminderGridView.AutoGenerateColumns = false;
            ReminderGridView.ReadOnly = true;
            ReminderGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ReminderGridView.MultiSelect = false;
            ReminderGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            ReminderGridView.DataError += (s, e) => e.ThrowException = false;
            EnsureCalenderColumns();
            FormatDataColumns();
            BindData();




        }

        private void EnsureCalenderColumns()
        {
            ReplaceWithCalendarColumn("currentDTDataGridViewTextBoxColumn", "CurrentDT");
            ReplaceWithCalendarColumn("upComingDTDataGridViewTextBoxColumn", "UpComingDT");

        }
        private void ReplaceWithCalendarColumn(string existingName, string dataPropertyName)
        {
            var old = ReminderGridView.Columns[existingName];
            if (old == null)
            {
                return;
            }
            int index = old.Index;
            string header = old.HeaderText;
            var mode = old.AutoSizeMode;
            ReminderGridView.Columns.RemoveAt(index);
            var cal = new DataGridViewCalendarColumn
            {
                Name = existingName,
                HeaderText = header,
                DataPropertyName = dataPropertyName,
                AutoSizeMode = mode,
            };
            cal.DefaultCellStyle.Format = "dd/MM/yyyy";
            cal.DefaultCellStyle.NullValue = ""; // show blank for nulls

            // ?? This line puts the new column back in the grid
            ReminderGridView.Columns.Insert(index, cal);
        }
        private void FormatDataColumns()
        {
            Set("CurrentDT");
            Set("UpComingDT");
            void Set(string dp)
            {
                var col = ReminderGridView.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => c.DataPropertyName == dp);
                if (col == null) { return; }
                col.DefaultCellStyle.Format = "dd/MM/yyyy";
                col.DefaultCellStyle.NullValue = "";
            }

        }
        private void BindData()
        {
            _items = new()
        {
            new Compliance {
                Assessment = "Fire Extinguisher", Frequency = 12,
                CurrentDT = DateTime.Today, UpComingDT = DateTime.Today.AddMonths(12),
                Remark = "Annual"
            },
            new Compliance {
                Assessment = "PPE Audit", Frequency = 6,
                CurrentDT = null, UpComingDT = DateTime.Today.AddMonths(1), // null on purpose
                ReminderSent = true, Remark = "Bi-annual"
            }
        };

            ReminderGridView.DataSource = _items;

            // Optional: convert blanks back to null on commit
            ReminderGridView.CellParsing += (s, e) =>
            {
                var dp = ReminderGridView.Columns[e.ColumnIndex].DataPropertyName;
                if (dp is "CurrentDT" or "UpComingDT")
                {
                    var sVal = e.Value?.ToString();
                    if (string.IsNullOrWhiteSpace(sVal)) { e.Value = null; e.ParsingApplied = true; }
                    else if (DateTime.TryParse(sVal, out var dt)) { e.Value = dt; e.ParsingApplied = true; }
                }
            };
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using var dlg = new DataEntryEditorForm();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _items.Add(dlg.Model);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var sel = CurrentItem;
            if (sel == null) { MessageBox.Show("Select a row to edit."); return; }

            var copy = new Compliance
            {
                Id = sel.Id,
                Assessment = sel.Assessment,
                Frequency = sel.Frequency,
                CurrentDT = sel.CurrentDT,
                UpComingDT = sel.UpComingDT,
                Fee = sel.Fee,
                ReminderSent = sel.ReminderSent,
                Remark = sel.Remark
            };

            using var dlg = new DataEntryEditorForm(copy);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                var updated = dlg.Model;  // or call dlg.SaveBackFromControls(); use copy
                sel.Assessment = updated.Assessment;
                sel.Frequency = updated.Frequency;
                sel.CurrentDT = updated.CurrentDT;
                sel.UpComingDT = updated.UpComingDT;
                sel.Fee = updated.Fee;
                sel.ReminderSent = updated.ReminderSent;
                sel.Remark = updated.Remark;

                ReminderGridView.Refresh();   // if your model doesn’t raise change notifications
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var sel = CurrentItem;
            if (sel == null) { MessageBox.Show("Select a row to delete."); return; }

            if (MessageBox.Show("Delete this item?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            _items.Remove(sel);
        }
    }
}
