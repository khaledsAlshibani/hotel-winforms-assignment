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
    public partial class LoginForm : Form
    {
        // SqlConnection conn = new SqlConnection(
        //     @"Data Source=np:\\.\pipe\LOCALDB#27675C72\tsql\query;
        //       Initial Catalog=hotel_db;
        //       Integrated Security=True;");

        SqlConnection conn;

        public LoginForm()
        {
            InitializeComponent();
            pwd_txt.PasswordChar = '*';
            DbUtils.StartLocalDb();
            string pipe = DbUtils.GetLocalDbPipe();
            conn = new SqlConnection(
                $@"Data Source={pipe};
                Initial Catalog=hotel_db;
                Integrated Security=True;");
        }

        private void CenterPanel()
        {
            login_pnl.Left = (this.ClientSize.Width - login_pnl.Width) / 2;
            login_pnl.Top = (this.ClientSize.Height - login_pnl.Height) / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private bool ShouldChangePasswordForm(int userId)
        {
            string sql = "SELECT IsFirstLogin FROM Users WHERE id = @userId";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@userId", userId);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 0 || dt.Rows[0].IsNull("IsFirstLogin") || !Convert.ToBoolean(dt.Rows[0]["IsFirstLogin"]))
            {
                return false;
            }

            ChangePasswordForm changePasswordForm = new ChangePasswordForm(userId, conn);
            if (changePasswordForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("log in again with the new password please");
            }
            return true;
        }

        private void OpenDashboard(int userId)
        {
            DashboardForm dashboardForm = new DashboardForm(userId, conn, this);
            dashboardForm.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text.Trim();
            string password = pwd_txt.Text.Trim();
            try
            {
                //PasswordHelper.TestDefaultUserPwd(conn, username);

                string sql = "SELECT id, PasswordHash FROM Users WHERE Username=@u";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@u", username);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("wrong user/pass");
                    return;
                }

                string storedHash = Convert.ToString(dt.Rows[0]["PasswordHash"]);
                if (!PasswordHelper.VerifyPassword(password, storedHash))
                {
                    MessageBox.Show("wrong user/pass");
                    return;
                }

                int userId = Convert.ToInt32(dt.Rows[0]["id"]);
                if (!ShouldChangePasswordForm(userId))
                {
                    OpenDashboard(userId);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void login_pnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
