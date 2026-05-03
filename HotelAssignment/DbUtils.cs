using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace HotelAssignment
{
    public static class DbUtils
    {
        // I needed to do this because I am uisng parallels to run windows on mac
        // see: https://kb.parallels.com/en/129699
        // or in terminal inside visual studio run: sqllocaldb start MSSQLLocalDB
        public static void StartLocalDb()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "sqllocaldb",
                Arguments = "start MSSQLLocalDB",
                CreateNoWindow = true,
                UseShellExecute = false
            })?.WaitForExit();
        }

        // take the pipe name for the LocalDB instance
        // same as running: sqllocaldb info MSSQLLocalDB
        public static string GetLocalDbPipe()
        {
            var process = new Process();
            process.StartInfo.FileName = "sqllocaldb";
            process.StartInfo.Arguments = "info MSSQLLocalDB";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            foreach (var line in output.Split('\n'))
            {
                var trimmed = line.Trim();

                if (trimmed.StartsWith("Instance pipe name:"))
                {
                    return trimmed.Replace("Instance pipe name:", "").Trim();
                }
            }

            throw new Exception("Could not find LocalDB pipe name");
        }

        public static void OpenConn(SqlConnection conn)
        {
            if (conn != null && conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public static void CloseConn(SqlConnection conn)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public static bool CheckConn(SqlConnection conn)
        {
            return CheckConn(conn, "no db connection!");
        }

        public static bool CheckConn(SqlConnection conn, string messageIfNull)
        {
            if (conn == null)
            {
                MessageBox.Show(messageIfNull);
                return false;
            }
            return true;
        }
    }
}
