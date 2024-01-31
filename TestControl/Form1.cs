using System.Collections.Generic;
using AfghanCalendar;
using System;
using System.Windows.Forms;

namespace TestControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DatePicker_DateChanged(object sender, DariDatePickerEventArgs e)
        {
            var datePicker = (DariCalendar)sender;
            var mes = string.Format("Old DariDate: {0}New DariDate: {1}DatePicker Format: {2}Afghan SelectedDate: {3}Gregorian SelectedDate: {4}" +
                                    "Number Of Days In Afghan SelectedMonth: {5}Afghan Year: {6}Afghan Month: {7}Afghan Day: {8}Afghan selectedDate In Long Format: {9}Is Holiday: {10}", 
                                    e.OldDariDate + Environment.NewLine, 
                                    e.NewDariDate + Environment.NewLine,
                                    datePicker.Value.Format + Environment.NewLine,
                                    datePicker.Value.DariSelectedDate + Environment.NewLine,
                                    datePicker.Value.GregorianSelectedDate.ToShortDateString() + Environment.NewLine,
                                    datePicker.Value.NumberOfDaysInDariSelectedMonth + Environment.NewLine,
                                    datePicker.Value.DariYear + Environment.NewLine,
                                    datePicker.Value.DariMonth + Environment.NewLine,
                                    datePicker.Value.DariDay + Environment.NewLine,
                                    DariDateHelper.GetLongDariDate(datePicker.Value.GregorianSelectedDate) + Environment.NewLine,
                                    DariDateHelper.IsHolidayDaroDate(datePicker.Value.DariSelectedDate) ? "تعطیل" : "غیر تعطیل");
            MessageBox.Show(mes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var persons = new List<Person>
                              {
                                  new Person { BirthDate = "1364/01/01", Fullname = "AAAAA"},
                                  new Person { BirthDate = "1352/07/24", Fullname = "BBBBB"},
                                  new Person { BirthDate = "1354/11/23", Fullname = "CCCCC"},
                                  new Person { BirthDate = "1380/05/11", Fullname = "DDDDD"}
                              };
            gridPerson.AutoGenerateColumns = false;
            gridPerson.DataSource = persons;

            BirthDate.CellDateChanged += BirthDate_CellDateChanged;
        }

        void BirthDate_CellDateChanged(DataGridViewDariDatePickerCell cell, DariDatePickerEventArgs e)
        {
            MessageBox.Show(string.Format(" Cell[{0},{1}] \r\n Old DariDate: {2} \r\n New DariDate: {3}", cell.RowIndex,
                                          cell.ColumnIndex, e.OldDariDate, e.NewDariDate));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    public class Person
    {
        public string BirthDate { get; set; }
        public string Fullname { get; set; }
    }
}
