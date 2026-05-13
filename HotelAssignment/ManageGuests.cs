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
    public partial class ManageGuests : Form
    {
        int guestFieldsPanelVisibleHeight;
        SqlConnection conn;
        int? selectedGuestId;
        bool suppressSelection;

        public ManageGuests()
        {
            InitializeComponent();
            guestFieldsPanelVisibleHeight = guest_fields_pnl.Height;
        }

        public ManageGuests(SqlConnection connection)
        {
            InitializeComponent();
            guestFieldsPanelVisibleHeight = guest_fields_pnl.Height;
            conn = connection;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadGuests();
            SetGuestFieldsPanelVisible(false);
        }

        private void SetGuestFieldsPanelVisible(bool visible)
        {
            guest_fields_pnl.Visible = visible;
            guest_fields_pnl.Height = visible ? guestFieldsPanelVisibleHeight : 0;
        }

        private void ClearFieldTexts()
        {
            first_name_txt.Clear();
            last_name_txt.Clear();
            phone_txt.Clear();
            email_txt.Clear();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!ConfirmDiscardFieldInput())
            {
                return;
            }
            LoadGuests();
        }

        private void search_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                search_btn_Click(sender, e);
            }
        }

        private void LoadGuests()
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }

            try
            {
                string term = search_txt.Text.Trim();
                string sql = "SELECT Id, FirstName, LastName, Phone, Email FROM Guests ";
                if (term != "")
                {
                    sql += "WHERE FirstName LIKE @q OR LastName LIKE @q OR ISNULL(Phone, N'') LIKE @q OR ISNULL(Email, N'') LIKE @q ";
                }
                sql += "ORDER BY Id";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                if (term != "")
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@q", "%" + term + "%");
                }
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
                guests_dgv.DataSource = dt;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Could not load guests: " + exception.Message);
            }
            finally
            {
                selectedGuestId = null;
                ClearFieldTexts();
                if (guests_dgv.Rows.Count > 0)
                {
                    guests_dgv.ClearSelection();
                }
                SetGuestFieldsPanelVisible(false);
            }
        }

        private void guests_dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (suppressSelection)
            {
                return;
            }
            if (guests_dgv.CurrentRow == null)
            {
                return;
            }
            FillFieldsFromRow(guests_dgv.CurrentRow);
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
            selectedGuestId = Convert.ToInt32(dataRowView["Id"]);
            first_name_txt.Text = dataRowView["FirstName"].ToString();
            last_name_txt.Text = dataRowView["LastName"].ToString();
            phone_txt.Text = dataRowView["Phone"] == DBNull.Value ? "" : dataRowView["Phone"].ToString();
            email_txt.Text = dataRowView["Email"] == DBNull.Value ? "" : dataRowView["Email"].ToString();
            SetGuestFieldsPanelVisible(true);
        }

        private bool FieldsHaveAnyInput()
        {
            if (first_name_txt.Text.Trim() != "")
            {
                return true;
            }
            if (last_name_txt.Text.Trim() != "")
            {
                return true;
            }
            if (phone_txt.Text.Trim() != "")
            {
                return true;
            }
            if (email_txt.Text.Trim() != "")
            {
                return true;
            }
            return false;
        }

        private bool ConfirmDiscardFieldInput()
        {
            if (!guest_fields_pnl.Visible)
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

        private void PrepareForNewGuest()
        {
            suppressSelection = true;
            selectedGuestId = null;
            ClearFieldTexts();
            if (guests_dgv.Rows.Count > 0)
            {
                guests_dgv.ClearSelection();
            }
            SetGuestFieldsPanelVisible(true);
            suppressSelection = false;
        }

        private void add_guest_btn_Click(object sender, EventArgs e)
        {
            // add/clear buttons both run this (may prompt if fields are not empty)
            if (!ConfirmDiscardFieldInput())
            {
                return;
            }
            PrepareForNewGuest();
        }

        private bool ValidateGuestFields()
        {
            string firstName = first_name_txt.Text.Trim();
            string lastName = last_name_txt.Text.Trim();
            if (!ValidationUtils.ValidateRequiredFields(firstName, lastName))
            {
                return false;
            }
            string phone = phone_txt.Text.Trim();
            string email = email_txt.Text.Trim();
            if (!ValidationUtils.ValidateMaxLength(firstName, 100, "First name is too long (100 chars max)"))
            {
                return false;
            }
            if (!ValidationUtils.ValidateMaxLength(lastName, 100, "Last name is too long (100 chars max)"))
            {
                return false;
            }
            if (!ValidationUtils.ValidateMaxLength(email, 200, "email too long"))
            {
                return false;
            }
            if (phone != "")
            {
                for (int i = 0; i < phone.Length; i++)
                {
                    if (!char.IsDigit(phone[i]))
                    {
                        MessageBox.Show("Phone must be digits only");
                        return false;
                    }
                }
                if (phone.Length != 9)
                {
                    MessageBox.Show("Phone must be exactly 9 digits");
                    return false;
                }
            }
            if (email != "")
            {
                int atSignIndex = email.IndexOf('@');
                if (atSignIndex < 1 || atSignIndex >= email.Length - 1)
                {
                    MessageBox.Show("Email needs text before and after the @ sign");
                    return false;
                }
                string domain = email.Substring(atSignIndex + 1);
                if (domain.IndexOf('.') < 0)
                {
                    MessageBox.Show("Email should look like name@example.com");
                    return false;
                }
            }
            return true;
        }

        private void AddParameter(SqlCommand cmd, string name, string valueOrEmpty)
        {
            string trimmed = valueOrEmpty.Trim();
            if (trimmed == "")
            {
                cmd.Parameters.AddWithValue(name, DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue(name, trimmed);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }
            if (!guest_fields_pnl.Visible)
            {
                MessageBox.Show("Open the form fields first (select a guest, or click Add).");
                return;
            }
            if (!ValidateGuestFields())
            {
                return;
            }

            try
            {
                try
                {
                    DbUtils.OpenConn(conn);
                    if (selectedGuestId == null)
                    {
                        string sql = "INSERT INTO Guests (FirstName, LastName, Phone, Email) VALUES (@fn, @ln, @ph, @em)";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@fn", first_name_txt.Text.Trim());
                        cmd.Parameters.AddWithValue("@ln", last_name_txt.Text.Trim());
                        AddParameter(cmd, "@ph", phone_txt.Text);
                        AddParameter(cmd, "@em", email_txt.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Guest saved.");
                        selectedGuestId = null;
                        ClearFieldTexts();
                        SetGuestFieldsPanelVisible(false);
                        LoadGuests();
                    }
                    else
                    {
                        string sql = "UPDATE Guests SET FirstName=@fn, LastName=@ln, Phone=@ph, Email=@em, UpdatedAt=SYSDATETIME() WHERE Id=@id";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@fn", first_name_txt.Text.Trim());
                        cmd.Parameters.AddWithValue("@ln", last_name_txt.Text.Trim());
                        AddParameter(cmd, "@ph", phone_txt.Text);
                        AddParameter(cmd, "@em", email_txt.Text);
                        cmd.Parameters.AddWithValue("@id", selectedGuestId.Value);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("saved");
                            SetGuestFieldsPanelVisible(false);
                            LoadGuests();
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
                MessageBox.Show("save failed " + exception.Message);
            }
        }

        private void delete_guest_btn_Click(object sender, EventArgs e)
        {
            if (!DbUtils.CheckConn(conn))
            {
                return;
            }
            DialogResult confirm = MessageBox.Show(
                "r you sure you want to delete this guest?",
                "Confirm?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            string sql = "DELETE FROM Guests WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", selectedGuestId.Value);
            try
            {
                try
                {
                    DbUtils.OpenConn(conn);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("done deleted");
                        selectedGuestId = null;
                        ClearFieldTexts();
                        SetGuestFieldsPanelVisible(false);
                        LoadGuests();
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
                    MessageBox.Show("Cant delete they still have reservations tied");
                }
            }
        }

        private void refresh_guest_btn_Click(object sender, EventArgs e)
        {
            if (!ConfirmDiscardFieldInput())
            {
                return;
            }
            selectedGuestId = null;
            ClearFieldTexts();
            SetGuestFieldsPanelVisible(false);
            LoadGuests();
        }
    }
}
