using System;
using System.Windows.Forms;

namespace HotelAssignment
{
    public static class ValidationUtils
    {
        public static bool ValidateRequiredFields(params string[] values)
        {
            if (values == null)
            {
                return true;
            }
            for (int i = 0; i < values.Length; i++)
            {
                string fieldValue = values[i];
                if (fieldValue == null || fieldValue.Trim() == "")
                {
                    MessageBox.Show("fill the required stuff");
                    return false;
                }
            }
            return true;
        }

        // too long
        public static bool ValidateMaxLength(string value, int maxLength, string messageIfTooLong)
        {
            if (value != null && value.Length > maxLength)
            {
                MessageBox.Show(messageIfTooLong);
                return false;
            }
            return true;
        }

        // too short
        public static bool ValidateMinLength(string value, int minLength, string messageIfTooShort)
        {
            int len = value == null ? 0 : value.Length;
            if (len < minLength)
            {
                MessageBox.Show(messageIfTooShort);
                return false;
            }
            return true;
        }

        // cant be in the past (date part)
        public static bool ValidateDateIsTodayOrFuture(DateTime date, string messageIfBeforeToday)
        {
            if (date.Date < DateTime.Today.Date)
            {
                MessageBox.Show(messageIfBeforeToday);
                return false;
            }
            return true;
        }

        // checkout has to be after checkin day
        public static bool ValidateEndDateAfterStartDate(DateTime startDate, DateTime endDate, string messageIfEndNotAfterStart)
        {
            if (endDate.Date <= startDate.Date)
            {
                MessageBox.Show(messageIfEndNotAfterStart);
                return false;
            }
            return true;
        }
    }
}
