using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelAssignment
{
    public partial class ReportsForm : Form
    {
        SqlConnection conn;

        public ReportsForm()
        {
            InitializeComponent();
        }

        public ReportsForm(SqlConnection connection)
        {
            InitializeComponent();
            conn = connection;
        }

        private void ReportsForm_Shown(object sender, EventArgs e)
        {
            ClampGuestHistoryComboLayout();
        }

        private void ReportsForm_Resize(object sender, EventArgs e)
        {
            ClampGuestHistoryComboLayout();
        }

        // combo list width follows longest guest name by default, so we cap it to the form
        private void ClampGuestHistoryComboLayout()
        {
            if (guest_history_cmb == null || guest_history_cmb.IsDisposed)
            {
                return;
            }
            int cap = Math.Max(180, ClientSize.Width - 40);
            int w = guest_history_cmb.Width + 2;
            if (w < 160)
            {
                w = 160;
            }
            if (w > cap)
            {
                w = cap;
            }
            guest_history_cmb.DropDownWidth = w;
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            single_table_cmb.SelectedIndex = 0;
            LoadGuestHistoryCombo();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadGuestHistoryCombo()
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }
            try
            {
                string sql = "SELECT Id, FirstName + N' ' + LastName AS FullName FROM Guests ORDER BY LastName, FirstName";
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
                guest_history_cmb.DataSource = dt;
                guest_history_cmb.DisplayMember = "FullName";
                guest_history_cmb.ValueMember = "Id";
                guest_history_cmb.SelectedIndex = -1;
                ClampGuestHistoryComboLayout();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Could not load guest list: " + exception.Message);
            }
        }

        private void run_single_report_btn_Click(object sender, EventArgs e)
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }
            string sql = "";
            if (single_table_cmb.SelectedIndex == 0)
            {
                sql = "SELECT Id, FirstName, LastName, Phone, Email, CreatedAt, UpdatedAt FROM Guests ORDER BY Id";
            }
            else if (single_table_cmb.SelectedIndex == 1)
            {
                sql = "SELECT Id, RoomNumber, Status, Floor, CreatedAt, UpdatedAt FROM Rooms ORDER BY Id";
            }
            else if (single_table_cmb.SelectedIndex == 2)
            {
                sql = "SELECT r.Id, r.GuestId, r.RoomId, g.FirstName + N' ' + g.LastName AS GuestName, rm.RoomNumber, r.CheckInDate, r.CheckOutDate, r.Status, r.TotalCost, r.CreatedAt, r.UpdatedAt FROM Reservations r INNER JOIN Guests g ON g.Id = r.GuestId INNER JOIN Rooms rm ON rm.Id = r.RoomId ORDER BY r.Id";
            }
            else
            {
                MessageBox.Show("Pick a table first.");
                return;
            }
            try
            {
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
                single_report_dgv.DataSource = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Report failed: " + exception.Message);
            }
        }

        private void run_guest_history_btn_Click(object sender, EventArgs e)
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }
            if (guest_history_cmb.SelectedIndex < 0 || guest_history_cmb.SelectedValue == null)
            {
                MessageBox.Show("Pick a guest first.");
                return;
            }
            int guestId = Convert.ToInt32(guest_history_cmb.SelectedValue);
            try
            {
                string sql = "SELECT g.Id AS GuestId, g.FirstName, g.LastName, g.Phone, g.Email, g.CreatedAt AS GuestCreatedAt, g.UpdatedAt AS GuestUpdatedAt, r.Id AS ReservationId, rm.RoomNumber, r.CheckInDate, r.CheckOutDate, r.Status, r.TotalCost, r.CreatedAt AS ReservationCreatedAt, r.UpdatedAt AS ReservationUpdatedAt FROM Guests g LEFT JOIN Reservations r ON r.GuestId = g.Id LEFT JOIN Rooms rm ON rm.Id = r.RoomId WHERE g.Id = @gid ORDER BY r.CheckInDate DESC, r.Id DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@gid", guestId);
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
                guest_hist_res_dgv.DataSource = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Guest history failed: " + exception.Message);
            }
        }
    }
}
