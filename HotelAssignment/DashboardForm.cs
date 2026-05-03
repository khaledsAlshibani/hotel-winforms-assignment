using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAssignment
{
    public partial class DashboardForm : Form
    {
        int userId;
        SqlConnection conn;
        LoginForm loginForm;

        public DashboardForm()
        {
            InitializeComponent();
            WireButtons();
        }

        public DashboardForm(int userId, SqlConnection conn, LoginForm loginForm)
        {
            InitializeComponent();
            this.userId = userId;
            this.conn = conn;
            this.loginForm = loginForm;
            WireButtons();
        }

        private void WireButtons()
        {
            manage_guests_btn.Click += ManageGuests_btn_Click;
            manage_rooms_btn.Click += ManageRooms_btn_Click;
            manage_reservations_btn.Click += ManageReservations_btn_Click;
            logout_btn.Click += Logout_btn_Click;
            refresh_overview_btn.Click += Refresh_overview_btn_Click;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }
            if (userId == 0)
            {
                return;
            }

            try
            {
                try
                {
                    DbUtils.OpenConn(conn);
                    string sql = "SELECT Username FROM Users WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", userId);
                    string userName = Convert.ToString(cmd.ExecuteScalar());
                    if (userName != "")
                    {
                        label3.Text = "Welcome, " + userName + " 👋";
                    }
                    FillOverviewFromDatabase();
                }
                finally
                {
                    DbUtils.CloseConn(conn);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("dashboard load failed " + exception.Message);
            }
        }

        private string CountRows(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            object result = cmd.ExecuteScalar();
            if (result == null || result == DBNull.Value)
            {
                return "0";
            }
            return result.ToString();
        }

        private void FillOverviewFromDatabase()
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }
            stat_total_guests_lbl.Text = "Total guests: " + CountRows("SELECT COUNT(*) FROM Guests");
            stat_total_rooms_lbl.Text = "Total rooms: " + CountRows("SELECT COUNT(*) FROM Rooms");
            stat_total_reservations_lbl.Text = "Total reservations: " + CountRows("SELECT COUNT(*) FROM Reservations");
            stat_available_rooms_lbl.Text = "Available rooms now: " + CountRows("SELECT COUNT(*) FROM Rooms WHERE Status = N'Available'");
            stat_pending_reservations_lbl.Text = "Pending reservations: " + CountRows("SELECT COUNT(*) FROM Reservations WHERE Status = N'Pending'");
            stat_checkins_today_lbl.Text = "Reservations with check-in today: " + CountRows("SELECT COUNT(*) FROM Reservations WHERE CAST(CheckInDate AS DATE) = CAST(GETDATE() AS DATE)");
        }

        private void Refresh_overview_btn_Click(object sender, EventArgs e)
        {
            RunOverviewRefresh(true);
        }

        // refresh stats on dashboard
        private void RunOverviewRefresh(bool showMessageOnError)
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }
            if (userId == 0)
            {
                return;
            }
            try
            {
                try
                {
                    DbUtils.OpenConn(conn);
                    FillOverviewFromDatabase();
                }
                finally
                {
                    DbUtils.CloseConn(conn);
                }
            }
            catch (Exception exception)
            {
                if (showMessageOnError)
                {
                    MessageBox.Show("Could not refresh overview: " + exception.Message);
                }
            }
        }

        private void ManageGuests_btn_Click(object sender, EventArgs e)
        {
            ManageGuests guestsForm = new ManageGuests(conn);
            guestsForm.ShowDialog(this);
            RunOverviewRefresh(false);
        }

        private void ManageRooms_btn_Click(object sender, EventArgs e)
        {
            ManageRooms roomsForm = new ManageRooms(conn);
            roomsForm.ShowDialog(this);
            RunOverviewRefresh(false);
        }

        private void ManageReservations_btn_Click(object sender, EventArgs e)
        {
            ManageReservations reservationsForm = new ManageReservations(conn);
            reservationsForm.ShowDialog(this);
            RunOverviewRefresh(false);
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                LoginForm login = new LoginForm();
                login.Show();
            }
            this.Close();
        }

        private void overview_grp_Enter(object sender, EventArgs e)
        {

        }
    }
}
