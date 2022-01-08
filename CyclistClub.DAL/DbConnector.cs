using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.DAL
{
    public static class DbConnector
    {
        public static SqlConnection connection { get; set; }

        public static void Open()
        {
            connection = new SqlConnection();
            const string host = @"localhost\SQLEXPRESS";
            const string port = "3306";
            const string db = "bicycle";
            const string user = "root";
            const string pwd = "";
            string connectString = $"Server={host};uid={user};pwd={pwd};database={db}";
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                string ErrorString = ex.Number.ToString();
                Console.WriteLine("[DB] Error Open Connection: " + ex.Message + "[" + ErrorString + "]");
            }

        }

    }
}
