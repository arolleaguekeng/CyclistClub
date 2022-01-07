using Connexion.DAL;
using CyclistClub.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.DAL
{
    public class MembreRepository : BaseRepository<Membres>
    {
        private readonly Sql sql;
        public void Add(Membres membres)
        {
            sql.Execute
            (
                "Sp_Person_Insert",
                new Sql.Parameter[]
                {
                    new Sql.Parameter("@name", System.Data.DbType.String, membres.FullName),
                    new Sql.Parameter("@phone", System.Data.DbType.Int64, membres.PhoneNumber),
                    new Sql.Parameter("@birth_day", System.Data.DbType.String, membres.Password),
                    new Sql.Parameter("@picture", System.Data.DbType.String, membres.Picture)
                },
                true
            );
        }




        public bool Selection(string Table, string login, string password, SqlConnection connection)
        {
            try
            {
                string queryString = "SELECT * FROM  " + Table + " WHERE login=" + "'" + login + "'" + " AND passwd=" + "'" + password + "';";
                Console.WriteLine("=== QueryString === " + queryString);
                SqlCommand cmd = new SqlCommand(queryString, connection);
                var resultQuery = cmd.ExecuteReader();
                bool res = resultQuery.Read();
                Console.WriteLine("=== QueryString === " + res);
                return res;
            }
            catch (SqlException)
            {
                return false;
            }

        }
        public bool Login(string Table,string login, string password)
        {
            try
            {
                var connector = new DbConnector();
                connector.connection.Open();
                var Cmd = Selection(Table, login, password, connector.connection);
                return Cmd;
            }
            catch (SqlException e)
            {
                string ErrorString = e.Number.ToString();
                Console.WriteLine("[DAO] Error: " + e.Message + "[" + ErrorString + "]", e);
                return false;
            }
        }
    }
}
