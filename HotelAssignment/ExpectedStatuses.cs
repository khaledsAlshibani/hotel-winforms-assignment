using System;
using System.Windows.Forms;

namespace HotelAssignment
{
    // status strings for room + reservation combo boxes
    internal static class ExpectedStatuses
    {
        public static readonly string[] RoomStatuses = new string[]
        {
            "Available",
            "Occupied",
            "Maintenance"
        };

        public static readonly string[] ReservationStatuses = new string[]
        {
            "Pending",
            "Confirmed",
            "Checked in",
            "Checked out",
            "Cancelled"
        };

        public static void FillRoomStatusCombo(ComboBox combo)
        {
            Fill(combo, RoomStatuses);
        }

        public static void FillReservationStatusCombo(ComboBox combo)
        {
            Fill(combo, ReservationStatuses);
        }

        private static void Fill(ComboBox combo, string[] items)
        {
            combo.Items.Clear();
            foreach (string statusLabel in items)
            {
                combo.Items.Add(statusLabel);
            }
            if (combo.Items.Count > 0)
            {
                combo.SelectedIndex = 0;
            }
        }

        // match db value to combo or default first item
        public static void SelectStatusFromDb(ComboBox combo, object dbValue)
        {
            string statusFromDatabase = dbValue == DBNull.Value ? "" : dbValue.ToString().Trim();
            if (statusFromDatabase == "")
            {
                combo.SelectedIndex = 0;
                return;
            }
            int found = -1;
            for (int i = 0; i < combo.Items.Count; i++)
            {
                if (string.Equals(combo.Items[i].ToString(), statusFromDatabase, StringComparison.OrdinalIgnoreCase))
                {
                    found = i;
                    break;
                }
            }
            if (found >= 0)
            {
                combo.SelectedIndex = found;
                return;
            }
            combo.Items.Add(statusFromDatabase);
            combo.SelectedIndex = combo.Items.Count - 1;
        }
    }
}
