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
        SqlConnection conn = new SqlConnection(
            @"Data Source=np:\\.\pipe\LOCALDB#5B33822A\tsql\query;
              Initial Catalog=hotel_db;
              Integrated Security=True;");

        public LoginForm()
        {
            InitializeComponent();
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

        private void OpenChangePasswordForm(int userId)
        {
            string sql = "SELECT IsFirstLogin FROM users WHERE id = @userId";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.SelectCommand.Parameters.AddWithValue("@userId", userId);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                // if is IsFirstLogin don't procees
                return;
            }
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(userId, conn);
            changePasswordForm.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_txt.Text.Trim();
            string password = pwd_txt.Text.Trim();
            try
            {
                string sql = "SELECT * FROM Users WHERE Username=@u AND PasswordHash=@p";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                adapter.SelectCommand.Parameters.AddWithValue("@u", username);
                adapter.SelectCommand.Parameters.AddWithValue("@p", password);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("You are authenticated");
                    int userId = Convert.ToInt32(dt.Rows[0]["id"]);
                    OpenChangePasswordForm(userId);
                } else
                {
                    MessageBox.Show("You are not authenticated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
