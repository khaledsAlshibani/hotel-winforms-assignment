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
        string currentPasswordHash;

        public ChangePasswordForm()
        {
            InitializeComponent();
            new_pwd_txt.PasswordChar = '*';
            confirm_new_pwd_txt.PasswordChar = '*';
        }
        public ChangePasswordForm(int userId, SqlConnection conn)
        {
            InitializeComponent();
            new_pwd_txt.PasswordChar = '*';
            confirm_new_pwd_txt.PasswordChar = '*';
            this.userId = userId;
            this.conn = conn;
            LoadCurrentPasswordHash();
        }

        private void LoadCurrentPasswordHash()
        {
            try
            {
                string sql = "SELECT PasswordHash FROM Users WHERE id = @userId";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userId", userId);
                try
                {
                    DbUtils.OpenConn(conn);
                    currentPasswordHash = Convert.ToString(cmd.ExecuteScalar());
                    if (currentPasswordHash == null)
                    {
                        currentPasswordHash = "";
                    }
                }
                finally
                {
                    DbUtils.CloseConn(conn);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Could not load account: " + exception.Message);
                currentPasswordHash = "";
            }
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

        private bool ValidateNewPassword()
        {
            string newPwd = new_pwd_txt.Text;
            string newPwdConfirm = confirm_new_pwd_txt.Text;
            if (!PasswordHelper.IsPasswordStrongEnough(newPwd, out string errorMessage))
            {
                MessageBox.Show(errorMessage);
                return false;
            }
            if (newPwd != newPwdConfirm)
            {
                MessageBox.Show("New password and confirm password do not match.");
                return false;
            }
            if (PasswordHelper.VerifyPassword(newPwd, currentPasswordHash))
            {
                MessageBox.Show("New password must be different from your current password.");
                return false;
            }
            return true;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (!ValidateNewPassword())
            {
                return;
            }

            string sql = "UPDATE Users SET PasswordHash = @password, IsFirstLogin = 0 WHERE id = @userId";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@password", PasswordHelper.HashPassword(new_pwd_txt.Text));
            cmd.Parameters.AddWithValue("@userId", userId);
            int rowsUpdated = 0;
            try
            {
                DbUtils.OpenConn(conn);
                rowsUpdated = cmd.ExecuteNonQuery();
            }
            finally
            {
                DbUtils.CloseConn(conn);
            }
            if (rowsUpdated > 0)
            {
                MessageBox.Show("password changed successfully");
                this.DialogResult = DialogResult.OK;
                this.Close();
            } else
            {
                MessageBox.Show("oops, failed to change password, try again!");
            }
        }
    }
}
