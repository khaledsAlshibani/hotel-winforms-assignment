using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelAssignment
{
    public partial class ManageReservations : Form
    {
        int reservationFieldsPanelVisibleHeight;
        SqlConnection conn;
        int? selectedReservationId;
        bool suppressSelection;

        public ManageReservations()
        {
            InitializeComponent();
            reservationFieldsPanelVisibleHeight = reservation_fields_pnl.Height;
            ExpectedStatuses.FillReservationStatusCombo(status_cmb);
            WireCostPreviewEvents();
        }

        public ManageReservations(SqlConnection connection)
        {
            InitializeComponent();
            reservationFieldsPanelVisibleHeight = reservation_fields_pnl.Height;
            ExpectedStatuses.FillReservationStatusCombo(status_cmb);
            WireCostPreviewEvents();
            conn = connection;
        }

        private void WireCostPreviewEvents()
        {
            check_in_dtp.ValueChanged += ReservationCostInputs_Changed;
            check_out_dtp.ValueChanged += ReservationCostInputs_Changed;
            cost_per_day_txt.TextChanged += ReservationCostInputs_Changed;
        }

        private void ReservationCostInputs_Changed(object sender, EventArgs e)
        {
            UpdateTotalCostPreview();
        }

        // nights for the hotel, checkout minus checkin, but at least 1
        private int BillableDayCount()
        {
            int nightGapDays = (check_out_dtp.Value.Date - check_in_dtp.Value.Date).Days;
            if (nightGapDays < 1)
            {
                return 1;
            }
            return nightGapDays;
        }

        private void UpdateTotalCostPreview()
        {
            int days = BillableDayCount();
            string costTextTrim = cost_per_day_txt.Text.Trim();
            if (costTextTrim == "")
            {
                total_preview_lbl.Text = "total: (no cost yet)";
                return;
            }
            if (decimal.TryParse(costTextTrim, out decimal perDay))
            {
                decimal total = decimal.Round(perDay * days, 2);
                total_preview_lbl.Text = "total " + total.ToString("N2");
            }
        }

        private void ManageReservations_Load(object sender, EventArgs e)
        {
            LoadGuestAndRoomCombos();
            LoadReservations();
            SetReservationFieldsPanelVisible(false);
        }

        private void SetReservationFieldsPanelVisible(bool visible)
        {
            reservation_fields_pnl.Visible = visible;
            reservation_fields_pnl.Height = visible ? reservationFieldsPanelVisibleHeight : 0;
        }

        private void ClearFieldTexts()
        {
            guest_cmb.SelectedIndex = -1;
            room_cmb.SelectedIndex = -1;
            check_in_dtp.Value = DateTime.Today;
            check_out_dtp.Value = DateTime.Today.AddDays(1);
            status_cmb.SelectedIndex = 0;
            cost_per_day_txt.Clear();
            UpdateTotalCostPreview();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadGuestAndRoomCombos()
        {
            LoadRoomCombo();
            LoadGuestCombo();
        }

        // fill room dropdown
        private void LoadRoomCombo()
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }
            try
            {
                string roomsSql = "SELECT Id, RoomNumber FROM Rooms ORDER BY RoomNumber";
                SqlDataAdapter roomsAdapter = new SqlDataAdapter(roomsSql, conn);
                DataTable dt2 = new DataTable();
                try
                {
                    DbUtils.OpenConn(conn);
                    roomsAdapter.Fill(dt2);
                }
                finally
                {
                    DbUtils.CloseConn(conn);
                }
                room_cmb.DataSource = dt2;
                room_cmb.DisplayMember = "RoomNumber";
                room_cmb.ValueMember = "Id";
                room_cmb.SelectedIndex = -1;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Could not load room list: " + exception.Message);
            }
        }

        // guest dropdown
        private void LoadGuestCombo()
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }
            try
            {
                string guestsSql = "SELECT Id, FirstName + ' ' + LastName AS FullName FROM Guests ORDER BY LastName, FirstName";
                SqlDataAdapter guestsAdapter = new SqlDataAdapter(guestsSql, conn);
                DataTable dt = new DataTable();
                try
                {
                    DbUtils.OpenConn(conn);
                    guestsAdapter.Fill(dt);
                }
                finally
                {
                    DbUtils.CloseConn(conn);
                }
                guest_cmb.DataSource = dt;
                guest_cmb.DisplayMember = "FullName";
                guest_cmb.ValueMember = "Id";
                guest_cmb.SelectedIndex = -1;
            }
            catch (Exception exception)
            {
                MessageBox.Show("guest list didnt load " + exception.Message);
            }
        }

        private void LoadReservations()
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }

            try
            {
                string sql = "SELECT r.Id, r.GuestId, r.RoomId, g.FirstName + ' ' + g.LastName AS GuestName, rm.RoomNumber, r.CheckInDate, r.CheckOutDate, r.Status, r.TotalCost FROM Reservations r INNER JOIN Guests g ON g.Id = r.GuestId INNER JOIN Rooms rm ON rm.Id = r.RoomId ORDER BY r.Id";
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
                reservations_dgv.DataSource = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Could not load reservations: " + exception.Message);
            }
            finally
            {
                selectedReservationId = null;
                ClearFieldTexts();
                if (reservations_dgv.Rows.Count > 0)
                {
                    reservations_dgv.ClearSelection();
                }
                SetReservationFieldsPanelVisible(false);
            }
        }

        private void reservations_dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (suppressSelection)
            {
                return;
            }
            if (reservations_dgv.CurrentRow == null)
            {
                return;
            }
            FillFieldsFromRow(reservations_dgv.CurrentRow);
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
            selectedReservationId = Convert.ToInt32(dataRowView["Id"]);
            guest_cmb.SelectedValue = Convert.ToInt32(dataRowView["GuestId"]);
            room_cmb.SelectedValue = Convert.ToInt32(dataRowView["RoomId"]);
            check_in_dtp.Value = Convert.ToDateTime(dataRowView["CheckInDate"]);
            check_out_dtp.Value = Convert.ToDateTime(dataRowView["CheckOutDate"]);
            ExpectedStatuses.SelectStatusFromDb(status_cmb, dataRowView["Status"]);
            if (dataRowView["TotalCost"] == DBNull.Value)
            {
                cost_per_day_txt.Clear();
            }
            else
            {
                decimal totalFromDatabase = Convert.ToDecimal(dataRowView["TotalCost"]);
                int days = BillableDayCount();
                decimal perDay = decimal.Round(totalFromDatabase / days, 2);
                cost_per_day_txt.Text = perDay.ToString();
            }
            UpdateTotalCostPreview();
            SetReservationFieldsPanelVisible(true);
        }

        private bool FieldsHaveAnyInput()
        {
            if (guest_cmb.SelectedIndex >= 0)
            {
                return true;
            }
            if (room_cmb.SelectedIndex >= 0)
            {
                return true;
            }
            if (status_cmb.SelectedIndex != 0)
            {
                return true;
            }
            if (cost_per_day_txt.Text.Trim() != "")
            {
                return true;
            }
            return false;
        }

        private bool ConfirmDiscardFieldInput()
        {
            if (!reservation_fields_pnl.Visible)
            {
                return true;
            }
            if (!FieldsHaveAnyInput())
            {
                return true;
            }
            DialogResult discardAnswer = MessageBox.Show(
                "The form has text that is not saved yet. Continue and discard it?",
                "Discard changes?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            return discardAnswer == DialogResult.Yes;
        }

        private void PrepareForNewReservation()
        {
            suppressSelection = true;
            selectedReservationId = null;
            ClearFieldTexts();
            if (reservations_dgv.Rows.Count > 0)
            {
                reservations_dgv.ClearSelection();
            }
            SetReservationFieldsPanelVisible(true);
            suppressSelection = false;
        }

        private void add_reservation_btn_Click(object sender, EventArgs e)
        {
            if (!ConfirmDiscardFieldInput())
            {
                return;
            }
            PrepareForNewReservation();
        }

        private bool ValidateReservationFields()
        {
            if (guest_cmb.SelectedIndex < 0 || room_cmb.SelectedIndex < 0 || status_cmb.SelectedIndex < 0)
            {
                MessageBox.Show("Please fill in all required fields.");
                return false;
            }

            DateTime checkIn = check_in_dtp.Value.Date;
            DateTime checkOut = check_out_dtp.Value.Date;

            if (!ValidationUtils.ValidateEndDateAfterStartDate(checkIn, checkOut, "checkout has to be after checkin"))
            {
                return false;
            }

            if (selectedReservationId == null)
            {
                if (!ValidationUtils.ValidateDateIsTodayOrFuture(checkIn, "new booking checkin cant be in the past"))
                {
                    return false;
                }
            }

            string costTrim = cost_per_day_txt.Text.Trim();
            if (costTrim == "")
            {
                MessageBox.Show("Cost per day is required");
                return false;
            }
            if (!ValidationUtils.ValidateMaxLength(costTrim, 20, "cost string too long (20 is max)"))
            {
                return false;
            }
            if (!decimal.TryParse(costTrim, out decimal costPerDayDecimal))
            {
                MessageBox.Show("cost has to be a valid number");
                return false;
            }
            if (costPerDayDecimal <= 0)
            {
                MessageBox.Show("cost cant be 0 or negative");
                return false;
            }
            if (costPerDayDecimal > 999999)
            {
                MessageBox.Show("Cost per day is too large");
                return false;
            }

            if (selectedReservationId == null)
            {
                int guestIdForCheck = Convert.ToInt32(guest_cmb.SelectedValue);
                if (GuestHasActiveReservationConflict(guestIdForCheck))
                {
                    MessageBox.Show("That guest already has a pending/confirmed/checked-in booking, pick someone else");
                    return false;
                }
            }

            if (ReservationStatusHoldsRoom(status_cmb.Text))
            {
                int roomIdForCheck = Convert.ToInt32(room_cmb.SelectedValue);
                if (RoomHasOverlappingActiveReservation(roomIdForCheck, checkIn, checkOut, selectedReservationId))
                {
                    MessageBox.Show("This room is already booked for overlapping dates");
                    return false;
                }
            }
            return true;
        }

        // statuses that occupy the room for overlap checks
        private static bool ReservationStatusHoldsRoom(string statusText)
        {
            return statusText == "Pending" || statusText == "Confirmed" || statusText == "Checked in";
        }

        // true if this guest already has a row in pending, confirmed, or checked in
        private bool GuestHasActiveReservationConflict(int guestId)
        {
            string sql = "SELECT COUNT(*) FROM Reservations WHERE GuestId = @gid AND Status IN (N'Pending', N'Confirmed', N'Checked in')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@gid", guestId);
            try
            {
                DbUtils.OpenConn(conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            finally
            {
                DbUtils.CloseConn(conn);
            }
        }

        // room overlap with other active booking
        private bool RoomHasOverlappingActiveReservation(int roomId, DateTime checkIn, DateTime checkOut, int? excludeReservationId)
        {
            string sql = "SELECT COUNT(*) FROM Reservations WHERE RoomId = @rid AND Status IN (N'Pending', N'Confirmed', N'Checked in') AND CheckInDate < @chkOut AND CheckOutDate > @chkIn";
            if (excludeReservationId != null)
            {
                sql += " AND Id <> @exid";
            }
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@rid", roomId);
            cmd.Parameters.AddWithValue("@chkIn", checkIn);
            cmd.Parameters.AddWithValue("@chkOut", checkOut);
            if (excludeReservationId != null)
            {
                cmd.Parameters.AddWithValue("@exid", excludeReservationId.Value);
            }
            try
            {
                DbUtils.OpenConn(conn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            finally
            {
                DbUtils.CloseConn(conn);
            }
        }

        private object TotalCostParameterValue()
        {
            string costTextTrim = cost_per_day_txt.Text.Trim();
            decimal perDay = Convert.ToDecimal(costTextTrim);
            int days = BillableDayCount();
            decimal total = decimal.Round(perDay * days, 2);
            return total;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }
            if (!ValidateReservationFields())
            {
                return;
            }

            int guestId = Convert.ToInt32(guest_cmb.SelectedValue);
            int roomId = Convert.ToInt32(room_cmb.SelectedValue);

            try
            {
                try
                {
                    DbUtils.OpenConn(conn);
                    if (selectedReservationId == null)
                    {
                        string sql = "INSERT INTO Reservations (GuestId, RoomId, CheckInDate, CheckOutDate, Status, TotalCost) VALUES (@gid, @rid, @chkIn, @chkOut, @st, @cost)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@gid", guestId);
                        cmd.Parameters.AddWithValue("@rid", roomId);
                        cmd.Parameters.AddWithValue("@chkIn", check_in_dtp.Value.Date);
                        cmd.Parameters.AddWithValue("@chkOut", check_out_dtp.Value.Date);
                        cmd.Parameters.AddWithValue("@st", status_cmb.Text);
                        cmd.Parameters.AddWithValue("@cost", TotalCostParameterValue());
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Reservation saved.");
                        selectedReservationId = null;
                        ClearFieldTexts();
                        SetReservationFieldsPanelVisible(false);
                        LoadReservations();
                    }
                    else
                    {
                        string sql = "UPDATE Reservations SET GuestId=@gid, RoomId=@rid, CheckInDate=@chkIn, CheckOutDate=@chkOut, Status=@st, TotalCost=@cost, UpdatedAt=SYSDATETIME() WHERE Id=@id";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@gid", guestId);
                        cmd.Parameters.AddWithValue("@rid", roomId);
                        cmd.Parameters.AddWithValue("@chkIn", check_in_dtp.Value.Date);
                        cmd.Parameters.AddWithValue("@chkOut", check_out_dtp.Value.Date);
                        cmd.Parameters.AddWithValue("@st", status_cmb.Text);
                        cmd.Parameters.AddWithValue("@cost", TotalCostParameterValue());
                        cmd.Parameters.AddWithValue("@id", selectedReservationId.Value);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation saved.");
                            SetReservationFieldsPanelVisible(false);
                            LoadReservations();
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
                MessageBox.Show("Could not save reservation: " + exception.Message);
            }
        }

        private void delete_reservation_btn_Click(object sender, EventArgs e)
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }
            DialogResult confirm = MessageBox.Show(
                "delete this reservation",
                "Confirm?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            string sql = "DELETE FROM Reservations WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", selectedReservationId.Value);
            try
            {
                try
                {
                    DbUtils.OpenConn(conn);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("deleted");
                        selectedReservationId = null;
                        ClearFieldTexts();
                        SetReservationFieldsPanelVisible(false);
                        LoadReservations();
                    }
                }
                finally
                {
                    DbUtils.CloseConn(conn);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("delete failed " + exception.Message);
            }
        }

        private void refresh_reservation_btn_Click(object sender, EventArgs e)
        {
            if (!ConfirmDiscardFieldInput())
            {
                return;
            }
            selectedReservationId = null;
            ClearFieldTexts();
            SetReservationFieldsPanelVisible(false);
            LoadGuestAndRoomCombos();
            LoadReservations();
        }
    }
}
