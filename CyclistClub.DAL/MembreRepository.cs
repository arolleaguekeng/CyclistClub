using CyclistClub.BO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.DAL
{
    public class MembreRepository : BaseRepository<Membres>
    {
        private string querry;

        public MembreRepository()
        {
        }

        public void Add(Membres membres)
        {

            string query = "INSERT INTO membres(nom, telephone, password,picture)  VALUES(@name, @phone, @password,@picture)";
            using (SqlCommand command = new SqlCommand(query, DbConnector.Connection()))
                {
                DbConnector.Connection().Open();
                    command.Parameters.AddWithValue("@id", membres.Id);
                    command.Parameters.AddWithValue("@name", membres.FullName);
                    command.Parameters.AddWithValue("@phone", membres.PhoneNumber);
                    command.Parameters.AddWithValue("@password", membres.Password);
                    command.Parameters.AddWithValue("@picture", membres.Picture);
                    command.ExecuteNonQuery();
                    Console.WriteLine("save done!");
                }

        }

        public bool Selection(string Table, string login, string password)
        {
            try
            {
                DbConnector.Connection().Open();
                string queryString = "SELECT * FROM  " + Table + " WHERE login=" + "'" + login + "'" + " AND passwd=" + "'" + password + "';";
                Console.WriteLine("=== QueryString === " + queryString);
                SqlCommand cmd = new SqlCommand(queryString);
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
                DbConnector.Connection().Open();
                var Cmd = Selection(Table, login, password);
                return Cmd;
            }
            catch (SqlException e)
            {
                string ErrorString = e.Number.ToString();
                Console.WriteLine("[DAO] Error: " + e.Message + "[" + ErrorString + "]", e);
                return false;
            }
        }

        public ObservableCollection<Membres> GetAll(string table)
        {

            try
            {
                using (SqlCommand command = new SqlCommand(querry))
                {
                    querry = $"SELECT * FROM {table}";
                    command.CommandText = querry;
                    command.Parameters.Clear();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long phone;
                            long.TryParse(reader["phone"].ToString(), out phone);
                            datas.Add(new Membres(reader["id_membre"].ToString(), reader["name"].ToString(), phone, reader["password"].ToString(), reader["picture"].ToString()));
                        }
                        return datas;
                    }
                }

            }
            catch
            {
                return null;
            }

        }


    }
}
