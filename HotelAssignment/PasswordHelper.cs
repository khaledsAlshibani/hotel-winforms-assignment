using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HotelAssignment
{
    public static class PasswordHelper
    {
        // length of the part after the bar (2nd part)
        private const int AfterBarSize = 32;
        // how many mix rounds
        private const int StirTimes = 10000;
        // bar between left and right in the saved line (1st part | 2nd part)
        private const char BarInMiddle = '|';

        // first login password text
        public const string DefaultPlainPassword = "admin";
        // Builds the default password hash value from the default plain password and the salt
        public static string DefaultPasswordHashValue => HashDefaultPasswordForSeed();

        // default name for the test helper
        public const string DefaultTestUsername = "admin";

        // same salt bytes for every password we hash in this app
        private static readonly byte[] SharedSaltForApp = Encoding.UTF8.GetBytes("HotelAsgnDefSlt1");

        // rebuild default hash from DefaultPlainPassword
        public static string HashDefaultPasswordForSeed()
        {
            return HashWithSalt(DefaultPlainPassword, SharedSaltForApp);
        }

        // hashes a new password for the users
        public static string HashPassword(string password)
        {
            return HashWithSalt(password, SharedSaltForApp);
        }

        // password + salt is the right part of the hash
        private static byte[] CheckBytesFromPassword(string password, byte[] salt)
        {
            // Rfc2898DeriveBytes mixes password and salt into a safe binary output
            using (Rfc2898DeriveBytes derive = new Rfc2898DeriveBytes(password, salt, StirTimes))
            {
                // GetBytes returns the right part of the hash (value of AfterBarSize)
                return derive.GetBytes(AfterBarSize);
            }
        }

        // stored string = base64salt | base64hash
        private static string HashWithSalt(string password, byte[] salt)
        {
            // mixing gives raw binary (byte array), not normal text. char/string are for unicode letters we read
            // we turn these bytes into letters for the database only on the next line with Base64
            byte[] rightPart = CheckBytesFromPassword(password, salt);
            // Convert.ToBase64String turns raw bytes into letters for the database
            return Convert.ToBase64String(salt) + BarInMiddle + Convert.ToBase64String(rightPart);
        }

        // from its name, it just checks if the password is correct
        public static bool VerifyPassword(string password, string stored)
        {
            if (string.IsNullOrEmpty(stored))
            {
                return false;
            }
            if (stored.IndexOf(BarInMiddle) < 0)
            {
                return password == stored;
            }
            string[] parts = stored.Split(BarInMiddle);
            if (parts.Length != 2)
            {
                return false;
            }
            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] rightFromSql = Convert.FromBase64String(parts[1]);
            byte[] rightFromLogin = CheckBytesFromPassword(password, salt);
            return SlowEquals(rightFromSql, rightFromLogin);
        }

        private static bool SlowEquals(byte[] leftBytes, byte[] rightBytes)
        {
            if (leftBytes == null || rightBytes == null || leftBytes.Length != rightBytes.Length)
            {
                return false;
            }
            int diff = 0;
            for (int i = 0; i < leftBytes.Length; i++)
            {
                diff |= leftBytes[i] ^ rightBytes[i];
            }
            return diff == 0;
        }

        // new password should be at least 6 chars, and contain upper, lower, number, symbol
        public static bool IsPasswordStrongEnough(string password, out string message)
        {
            message = "";
            if (password == null || password.Length < 6)
            {
                message = "Password must be at least 6 characters.";
                return false;
            }
            bool upper = false;
            bool lower = false;
            bool digit = false;
            bool special = false;
            foreach (char character in password)
            {
                if (char.IsUpper(character))
                {
                    upper = true;
                }
                else if (char.IsLower(character))
                {
                    lower = true;
                }
                else if (char.IsDigit(character))
                {
                    digit = true;
                }
                else if (!char.IsLetterOrDigit(character))
                {
                    special = true;
                }
            }
            if (!upper || !lower || !digit || !special)
            {
                message = "password must contain upper, lower, number, and a symbol like ! or whatever";
                return false;
            }
            return true;
        }

        // dev helper for testing purposes
        public static void TestDefaultUserPwd(SqlConnection conn)
        {
            TestDefaultUserPwd(conn, DefaultTestUsername);
        }

        // dev helper for testing purposes for TestDefaultUserPwd
        public static void TestDefaultUserPwd(SqlConnection conn, string username)
        {
            if (!DbUtils.CheckConn(conn, "no database connection"))
            {
                return;
            }

            string sql = "UPDATE Users SET PasswordHash = @hashedPassword, IsFirstLogin = 1 WHERE Username = @username";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@hashedPassword", DefaultPasswordHashValue);
            cmd.Parameters.AddWithValue("@username", username);
            try
            {
                try
                {
                    DbUtils.OpenConn(conn);
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("reset password to " + DefaultPlainPassword);
                    }
                }
                finally
                {
                    DbUtils.CloseConn(conn);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("test pwd reset failed " + exception.Message);
            }
        }
    }
}
