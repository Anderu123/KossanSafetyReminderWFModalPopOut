using KossanSafetyRemnder;
using System.ComponentModel;
using System.Windows.Forms;

namespace SafetyReminderWF
{
    public partial class DataEntryForm : Form
    {
        public BindingList<Compliance> _items = new();
        public DataEntryForm()
        {
            InitializeComponent();
            ReminderGridView.AutoGenerateColumns = false;
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
            if(old==null)
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
        //private void BindData()
        //{
        //    _items = new()
        //    {
        //        new Compliance
        //        {

        //        }

        //    }
        //}

    }
}
