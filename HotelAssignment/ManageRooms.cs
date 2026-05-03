using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelAssignment
{
    public partial class ManageRooms : Form
    {
        int roomFieldsPanelVisibleHeight;
        SqlConnection conn;
        int? selectedRoomId;
        bool suppressSelection;

        public ManageRooms()
        {
            InitializeComponent();
            roomFieldsPanelVisibleHeight = room_fields_pnl.Height;
            ExpectedStatuses.FillRoomStatusCombo(status_cmb);
            ExpectedFloors.FillFloorCombo(floor_cmb);
        }

        public ManageRooms(SqlConnection connection)
        {
            InitializeComponent();
            roomFieldsPanelVisibleHeight = room_fields_pnl.Height;
            ExpectedStatuses.FillRoomStatusCombo(status_cmb);
            ExpectedFloors.FillFloorCombo(floor_cmb);
            conn = connection;
        }

        private void ManageRooms_Load(object sender, EventArgs e)
        {
            LoadRooms();
            SetRoomFieldsPanelVisible(false);
        }

        private void SetRoomFieldsPanelVisible(bool visible)
        {
            room_fields_pnl.Visible = visible;
            room_fields_pnl.Height = visible ? roomFieldsPanelVisibleHeight : 0;
        }

        private void ClearFieldTexts()
        {
            room_number_txt.Clear();
            status_cmb.SelectedIndex = 0;
            floor_cmb.SelectedIndex = 0;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadRooms()
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }

            try
            {
                string sql = "SELECT Id, RoomNumber, Status, Floor FROM Rooms ORDER BY Id";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                try
                {
                    DbUtils.OpenConn(conn);
                    adapter.Fill(dt);
                }
                finally
                {
                    DbUtils.CloseConn(conn);
                }
                rooms_dgv.DataSource = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Could not load rooms: " + exception.Message);
            }
            finally
            {
                selectedRoomId = null;
                ClearFieldTexts();
                if (rooms_dgv.Rows.Count > 0)
                {
                    rooms_dgv.ClearSelection();
                }
                SetRoomFieldsPanelVisible(false);
            }
        }

        private void rooms_dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (suppressSelection)
            {
                return;
            }
            if (rooms_dgv.CurrentRow == null)
            {
                return;
            }
            FillFieldsFromRow(rooms_dgv.CurrentRow);
        }

        private void FillFieldsFromRow(DataGridViewRow row)
        {
            if (row == null)
            {
                return;
            }
            if (row.IsNewRow)
            {
                return;
            }
            DataRowView dataRowView = row.DataBoundItem as DataRowView;
            if (dataRowView == null)
            {
                return;
            }
            selectedRoomId = Convert.ToInt32(dataRowView["Id"]);
            room_number_txt.Text = dataRowView["RoomNumber"].ToString();
            ExpectedStatuses.SelectStatusFromDb(status_cmb, dataRowView["Status"]);
            ExpectedFloors.SelectFloorFromDb(floor_cmb, dataRowView["Floor"]);
            SetRoomFieldsPanelVisible(true);
        }

        private bool FieldsHaveAnyInput()
        {
            if (room_number_txt.Text.Trim() != "")
            {
                return true;
            }
            if (status_cmb.SelectedIndex != 0)
            {
                return true;
            }
            if (floor_cmb.SelectedIndex != 0)
            {
                return true;
            }
            return false;
        }

        private bool ConfirmDiscardFieldInput()
        {
            if (!room_fields_pnl.Visible)
            {
                return true;
            }
            if (!FieldsHaveAnyInput())
            {
                return true;
            }
            DialogResult discardAnswer = MessageBox.Show(
                "Stuff not saved, chuck it?",
                "Discard",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            return discardAnswer == DialogResult.Yes;
        }

        private void PrepareForNewRoom()
        {
            suppressSelection = true;
            selectedRoomId = null;
            ClearFieldTexts();
            if (rooms_dgv.Rows.Count > 0)
            {
                rooms_dgv.ClearSelection();
            }
            SetRoomFieldsPanelVisible(true);
            suppressSelection = false;
        }

        private void add_room_btn_Click(object sender, EventArgs e)
        {
            if (!ConfirmDiscardFieldInput())
            {
                return;
            }
            PrepareForNewRoom();
        }

        private bool ValidateRoomFields()
        {
            string roomNumber = room_number_txt.Text.Trim();
            if (!ValidationUtils.ValidateRequiredFields(roomNumber))
            {
                return false;
            }
            if (status_cmb.SelectedIndex < 0 || floor_cmb.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill in all required fields.");
                return false;
            }
            if (!ValidationUtils.ValidateMaxLength(roomNumber, 4, "Room number is too long, max is 4 digits"))
            {
                return false;
            }
            for (int i = 0; i < roomNumber.Length; i++)
            {
                if (!char.IsLetterOrDigit(roomNumber[i]))
                {
                    MessageBox.Show("Room number can only use letters and digits, no spaces or symbols");
                    return false;
                }
            }
            return true;
        }

        private object FloorParameterValue()
        {
            return ExpectedFloors.GetSelectedFloorNumber(floor_cmb);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }
            if (!ValidateRoomFields())
            {
                return;
            }

            try
            {
                try
                {
                    DbUtils.OpenConn(conn);
                    if (selectedRoomId == null)
                    {
                        string sql = "INSERT INTO Rooms (RoomNumber, Status, Floor) VALUES (@rn, @st, @fl)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@rn", room_number_txt.Text.Trim());
                        cmd.Parameters.AddWithValue("@st", status_cmb.Text);
                        cmd.Parameters.AddWithValue("@fl", FloorParameterValue());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Room saved.");
                        selectedRoomId = null;
                        ClearFieldTexts();
                        SetRoomFieldsPanelVisible(false);
                        LoadRooms();
                    }
                    else
                    {
                        string sql = "UPDATE Rooms SET RoomNumber=@rn, Status=@st, Floor=@fl, UpdatedAt=SYSDATETIME() WHERE Id=@id";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@rn", room_number_txt.Text.Trim());
                        cmd.Parameters.AddWithValue("@st", status_cmb.Text);
                        cmd.Parameters.AddWithValue("@fl", FloorParameterValue());
                        cmd.Parameters.AddWithValue("@id", selectedRoomId.Value);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room saved.");
                            SetRoomFieldsPanelVisible(false);
                            LoadRooms();
                        }
                    }
                }
                finally
                {
                    DbUtils.CloseConn(conn);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Could not save room: " + exception.Message);
            }
        }

        private void delete_room_btn_Click(object sender, EventArgs e)
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }
            DialogResult confirm = MessageBox.Show(
                "delete room?",
                "sure?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            string sql = "DELETE FROM Rooms WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", selectedRoomId.Value);
            try
            {
                try
                {
                    DbUtils.OpenConn(conn);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Room deleted.");
                        selectedRoomId = null;
                        ClearFieldTexts();
                        SetRoomFieldsPanelVisible(false);
                        LoadRooms();
                    }
                }
                finally
                {
                    DbUtils.CloseConn(conn);
                }
            }
            catch (Exception exception)
            {
                SqlException sqlException = exception as SqlException;
                if (sqlException != null && sqlException.Number == 547)
                {
                    MessageBox.Show("Cannot delete this room as there are reservations linked to it.");
                }
                else
                {
                    MessageBox.Show("delete error " + exception.Message);
                }
            }
        }

        private void refresh_room_btn_Click(object sender, EventArgs e)
        {
            if (!ConfirmDiscardFieldInput())
            {
                return;
            }
            selectedRoomId = null;
            ClearFieldTexts();
            SetRoomFieldsPanelVisible(false);
            LoadRooms();
        }
    }
}
