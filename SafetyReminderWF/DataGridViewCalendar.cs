using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace KossanSafetyRemnder
{
    // Column that hosts a nullable-safe DateTimePicker editor
    public sealed class DataGridViewCalendarColumn : DataGridViewColumn
    {
        public DataGridViewCalendarColumn() : base(new DataGridViewCalendarCell()) { }

        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                if (value != null && !typeof(DataGridViewCalendarCell).IsAssignableFrom(value.GetType()))
                    throw new InvalidCastException("Must be a DataGridViewCalendarCell");
                base.CellTemplate = value;
            }
        }
    }

    public sealed class DataGridViewCalendarCell : DataGridViewTextBoxCell
    {
        public DataGridViewCalendarCell()
        {
            Style.Format = "dd/MM/yyyy";
        }

        public override Type EditType => typeof(DataGridViewCalendarEditingControl);
        public override Type ValueType => typeof(DateTime?);   // allow nulls
        public override object DefaultNewRowValue => null;

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle style)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, style);
            var ctl = DataGridView.EditingControl as DataGridViewCalendarEditingControl;

            // Normalize current cell value -> nullable DateTime
            DateTime? v = null;
            var cellVal = Value;
            if (cellVal is DateTime d) v = d;
            else if (cellVal is string s && DateTime.TryParse(s, out var d2)) v = d2;

            ctl!.SetNullableValue(v); // never passes null to DateTimePicker.Value
        }

        // Convert display text back to a nullable DateTime on commit
        public override object ParseFormattedValue(object formattedValue, DataGridViewCellStyle cellStyle,
            TypeConverter formattedValueTypeConverter, TypeConverter valueTypeConverter)
        {
            var s = formattedValue?.ToString();
            if (string.IsNullOrWhiteSpace(s)) return null;
            return DateTime.TryParse(s, out var dt) ? dt : null;
        }
    }

    [ToolboxItem(false)]
    [DesignerCategory("Code")]
    public sealed class DataGridViewCalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        private DataGridView _grid;
        private bool _valueChanged;
        private int _rowIndex;

        public DataGridViewCalendarEditingControl()
        {
            Format = DateTimePickerFormat.Custom;
            CustomFormat = "dd/MM/yyyy";
            ShowCheckBox = true;   // unchecked => “null” visually
            Checked = false;
        }

        // Public helper for the cell to set a nullable value safely
        public void SetNullableValue(DateTime? v)
        {
            if (v.HasValue)
            {
                var val = v.Value;
                if (val < MinDate) val = MinDate;
                if (val > MaxDate) val = MaxDate;
                Checked = true;
                CustomFormat = "dd/MM/yyyy";
                Value = val; // Value is never null
            }
            else
            {
                Checked = false;
                CustomFormat = " ";  // blank look while keeping Value valid
                if (Value < MinDate || Value > MaxDate)
                    Value = DateTime.Today;
            }
        }

        // --- IDataGridViewEditingControl members (design-time hidden) ---
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object EditingControlFormattedValue
        {
            get => Checked ? Value.ToString("dd/MM/yyyy") : string.Empty;
            set
            {
                if (value == null || value == DBNull.Value)
                {
                    SetNullableValue(null);
                    return;
                }
                var s = value.ToString();
                if (string.IsNullOrWhiteSpace(s)) { SetNullableValue(null); return; }
                SetNullableValue(DateTime.TryParse(s, out var d) ? d : (DateTime?)null);
            }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context) => EditingControlFormattedValue;

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle style)
        {
            Font = style.Font;
            CalendarForeColor = style.ForeColor;
            CalendarMonthBackground = style.BackColor;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int EditingControlRowIndex { get => _rowIndex; set => _rowIndex = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataGridView EditingControlDataGridView { get => _grid; set => _grid = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool EditingControlValueChanged { get => _valueChanged; set => _valueChanged = value; }

        public bool RepositionEditingControlOnValueChange => false;
        public Cursor EditingPanelCursor => base.Cursor;
        public void PrepareEditingControlForEdit(bool selectAll) { }

        protected override void OnValueChanged(EventArgs e)
        {
            // Keep blank look in sync with checkbox
            CustomFormat = Checked ? "dd/MM/yyyy" : " ";
            _valueChanged = true;
            _grid?.NotifyCurrentCellDirty(true);
            base.OnValueChanged(e);
        }

        public bool EditingControlWantsInputKey(Keys key, bool gridWants)
        {
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                case Keys.Home:
                case Keys.End:
                case Keys.PageUp:
                case Keys.PageDown:
                    return true;
                default:
                    return !gridWants;
            }
        }
    }
}
