using System;
using System.Windows.Forms;

namespace HotelAssignment
{
    internal static class ExpectedFloors
    {
        private static readonly int[] FloorNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

        private static readonly string[] FloorLabels = new string[]
        {
            "Floor 1",
            "Floor 2",
            "Floor 3",
            "Floor 4",
            "Floor 5",
            "Floor 6",
            "Floor 7"
        };

        public static void FillFloorCombo(ComboBox combo)
        {
            combo.Items.Clear();
            foreach (string label in FloorLabels)
            {
                combo.Items.Add(label);
            }
            if (combo.Items.Count > 0)
            {
                combo.SelectedIndex = 0;
            }
        }

        public static int GetSelectedFloorNumber(ComboBox combo)
        {
            int selectedIndex = combo.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= FloorNumbers.Length)
            {
                return FloorNumbers[0];
            }
            return FloorNumbers[selectedIndex];
        }

        public static void SelectFloorFromDb(ComboBox combo, object dbValue)
        {
            if (dbValue == DBNull.Value)
            {
                combo.SelectedIndex = 0;
                return;
            }
            int floorNumber = Convert.ToInt32(dbValue);
            for (int i = 0; i < FloorNumbers.Length; i++)
            {
                if (FloorNumbers[i] == floorNumber)
                {
                    combo.SelectedIndex = i;
                    return;
                }
            }
            combo.SelectedIndex = 0;
        }
    }
}
