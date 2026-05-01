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
    public partial class ChangePasswordForm : Form
    {
        int userId;
        SqlConnection conn;

        public ChangePasswordForm()
        {
            InitializeComponent();
        }
        public ChangePasswordForm(int userId, SqlConnection conn)
        {
            InitializeComponent();
            this.userId = userId;
            this.conn = conn;
        }

        private void CenterPanel()
        {
            change_pwd_pnl.Left = (this.ClientSize.Width - change_pwd_pnl.Width) / 2;
            change_pwd_pnl.Top = (this.ClientSize.Height - change_pwd_pnl.Height) / 2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private bool ValidateNewPassword ()
        {
            string newPwd = new_pwd_txt.Text;
            string newPwdConfirm = confirm_new_pwd_txt.Text;
            if (newPwd == newPwdConfirm)
            {
                return true;
            } else
            {
                MessageBox.Show("New password and confirm password do not match.");
                return false;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateNewPassword())
            {
                return;
            }

            string sql = "UPDATE Users SET PasswordHash = @password, IsFirstLogin = true WHERE id = @userId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@password", new_pwd_txt.Text);
            cmd.Parameters.AddWithValue("@userId", userId);
            conn.Open();
            int res = cmd.ExecuteNonQuery();
            conn.Close();
            if (res > 0)
            {
                MessageBox.Show("You have changed your password successfully");
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            } else
            {
                MessageBox.Show("Failed to change password. Please try again.");
            }
        }
    }
}
