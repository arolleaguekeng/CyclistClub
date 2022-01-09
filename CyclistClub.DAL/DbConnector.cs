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

        public static SqlConnection Connection()
        {

            const string host = @"DESKTOP-ISA9BMQ";
            const string port = "3306";
            const string db = "bicycle";
            const string user = "sa";
            const string pwd = "root";
            string connectString = $"Server={host};uid={user};pwd={pwd};database={db}";
            connection = new SqlConnection(connectString);
            return connection;
        }

    }
}
