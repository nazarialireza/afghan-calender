using System;

namespace AfghanCalendar
{
    public class DariDatePickerEventArgs : EventArgs
    {
        public DariDatePickerEventArgs(string newDariDate, string oldDariDate)
        {
            if (!DariDateHelper.ValidateDariDate(newDariDate) || (!string.IsNullOrEmpty(oldDariDate) && !DariDateHelper.ValidateDariDate(oldDariDate)))
                throw new Exception("Incorrect Dari Date.");
            NewDariDate = newDariDate;
            OldDariDate = oldDariDate;
        }

        public string NewDariDate { get; private set; }
        public string OldDariDate { get; private set; }
    }
}
