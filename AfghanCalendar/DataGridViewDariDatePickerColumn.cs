using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AfghanCalendar
{
    public class DataGridViewDariDatePickerColumn : DataGridViewColumn
    {
        private readonly DataGridViewDariDatePickerCell _cellTemplate;
        private DateFormat _dateFormat;
        private CalendarTheme _theme;
        private bool _showDariDigitInCell;
        public delegate void DariDatePickerColumnDateChangedHandler(DataGridViewDariDatePickerCell cell, DariDatePickerEventArgs e);
        public event DariDatePickerColumnDateChangedHandler CellDateChanged;
        protected virtual void OnCellDateChanged(DataGridViewDariDatePickerCell cell, DariDatePickerEventArgs e)
        {
            if (CellDateChanged != null) CellDateChanged(cell, e);
        }

        public DataGridViewDariDatePickerColumn()
        {
            _dateFormat = DateFormat.Short;
            _theme = CalendarTheme.WhiteSmoke;
            _showDariDigitInCell = false;
            _cellTemplate = new DataGridViewDariDatePickerCell();
            _cellTemplate.CellDateChanged += OnCellDateChanged;
            CellTemplate = _cellTemplate;
        }

        public override object Clone()
        {
            var column = (DataGridViewDariDatePickerColumn)base.Clone();
            if (column != null)
            {
                column.DateFormat = DateFormat;
                column.Theme = Theme;
                column.ShowDariDigitInCell = ShowDariDigitInCell;
            }
            return column;
        }

        /// <summary>
        /// Gets or sets format of the date represented by this instance.
        /// </summary>
        [Description("Gets or sets format of the date represented by this instance.")]
        public DateFormat DateFormat
        {
            get { return _dateFormat; }
            set
            {
                _dateFormat = value;
                _cellTemplate.DateFormat = value;
            }
        }

        /// <summary>
        /// Show Dari digit in cell.
        /// </summary>
        [Description("Show Dari digit in cell.")]
        public bool ShowDariDigitInCell
        {
            get { return _showDariDigitInCell; }
            set
            {
                _showDariDigitInCell = value;
                _cellTemplate.ShowDariDigitInCell = value;
            }
        }

        /// <summary>
        /// Gets or sets the theme assigned to the control.
        /// </summary>
        [Description("Gets or sets the theme assigned to the control.")]
        public CalendarTheme Theme
        {
            get { return _theme; }
            set
            {
                _theme = value;
                _cellTemplate.Theme = value;
            }
        }
    }

    public class DataGridViewDariDatePickerCell : DataGridViewTextBoxCell
    {
        private DateFormat _dateFormat;
        private CalendarTheme _theme;
        private bool _showDariDigitInCell;
        internal event Action<DataGridViewDariDatePickerCell, DariDatePickerEventArgs> CellDateChanged;
        internal void OnCellDateChanged(DataGridViewDariDatePickerCell arg1, DariDatePickerEventArgs arg2)
        {
            if (CellDateChanged != null) CellDateChanged(arg1, arg2);
        }

        public override object Clone()
        {
            var cell = (DataGridViewDariDatePickerCell)base.Clone();
            cell.DateFormat = DateFormat;
            cell.Theme = Theme;
            cell.ShowDariDigitInCell = ShowDariDigitInCell;
            cell.CellDateChanged = OnCellDateChanged;
            return cell;
        }

        /// <summary>
        /// Gets or sets format of the date represented by this instance.
        /// </summary>
        [Description("Gets or sets format of the date represented by this instance.")]
        public DateFormat DateFormat
        {
            get { return _dateFormat; }
            set
            {
                _dateFormat = value;
                if (DataGridView != null)
                    DataGridView.InvalidateCell(this);
            }
        }

        /// <summary>
        /// Gets or sets the theme assigned to the control.
        /// </summary>
        [Description("Gets or sets the theme assigned to the control.")]
        public CalendarTheme Theme
        {
            get { return _theme; }
            set
            {
                _theme = value;
                if (DataGridView != null)
                    DataGridView.InvalidateCell(this);
            }
        }

        /// <summary>
        /// Show Dari digit in cell.
        /// </summary>
        [Description("Show Dari digit in cell.")]
        public bool ShowDariDigitInCell
        {
            get { return _showDariDigitInCell; }
            set
            {
                _showDariDigitInCell = value;
                if (DataGridView != null)
                    DataGridView.InvalidateCell(this);
            }
        }

        protected override void Paint(System.Drawing.Graphics graphics, System.Drawing.Rectangle clipBounds, System.Drawing.Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            var val = (string)value;
            if (DariDateHelper.ValidateDariDate(val))
            {
                if (DateFormat == DateFormat.Long)
                    val = DariDateHelper.GetLongDariDate(DariDateHelper.GetGregorianDate(val));
                if (ShowDariDigitInCell)
                    val = DariDateHelper.ToDariDigit(val);
            }
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, val, errorText, cellStyle, advancedBorderStyle, paintParts);
        }

        private DariDatePickerEditingControl _editControl = null;
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            _editControl = DataGridView.EditingControl as DariDatePickerEditingControl;
            if (_editControl == null || initialFormattedValue == null) return;
            _editControl.Value.Format = DateFormat;
            _editControl.Value.Theme = Theme;
            _editControl.CancelDateChanged = true;
            _editControl.Value.DariSelectedDate = (string)initialFormattedValue;
            _editControl.CancelDateChanged = false;
            _editControl.DateChanged += ctl_DateChanged;
        }

        void ctl_DateChanged(object sender, DariDatePickerEventArgs e)
        {
            // do you want remove datepicker after changed date? uncomment below line
            //_editControl.DateChanged -= ctl_DateChanged;
            OnCellDateChanged(this, e);
            //DataGridView.EndEdit();
        }

        public override void DetachEditingControl()
        {
            _editControl.DateChanged -= ctl_DateChanged;
            base.DetachEditingControl();
        }

        public override Type EditType
        {
            get { return typeof(DariDatePickerEditingControl); }
        }

        public override Type ValueType
        {
            get { return typeof(object); }
        }

        public override object DefaultNewRowValue
        {
            get { return string.Empty; }
        }
    }

    class DariDatePickerEditingControl : DariCalendar, IDataGridViewEditingControl
    {
        private bool _valueChanged = false;

        public DariDatePickerEditingControl()
        {

        }

        public object EditingControlFormattedValue
        {
            get { return this.Value.DariSelectedDate; }
            set { this.Value.DariSelectedDate = (string)value; }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {

        }

        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return !dataGridViewWantsInputKey;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {

        }

        public int EditingControlRowIndex { get; set; }

        public DataGridView EditingControlDataGridView { get; set; }

        public bool RepositionEditingControlOnValueChange
        {
            get { return false; }
        }

        public bool EditingControlValueChanged
        {
            get { return _valueChanged; }
            set { _valueChanged = value; }
        }

        public Cursor EditingPanelCursor
        {
            get { return base.Cursor; }
        }

        internal bool CancelDateChanged { private get; set; }

        protected override void OnDateChanged(DariDatePickerEventArgs e)
        {
            if (CancelDateChanged) return;
            _valueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnDateChanged(e);
        }
    }
}
