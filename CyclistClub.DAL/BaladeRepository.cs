using CyclistClub.BO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.DAL
{
    public class BaladeRepository :BaseRepository<Balade>
    {
        public void Add(Balade balade)
        {
            //string id,string name , DateTime date, double tarrif
            string query = "INSERT INTO balades(id_balade, date_balade, tarrif,lieux_depart,lieux_arrivee)  VALUES(@id_balade, @date_balade, @tarrif,@depart,@arrivee)";
            using (SqlCommand command = new SqlCommand(query))
            {
                DbConnector.Connection().Open();
                command.Parameters.AddWithValue("@date", balade.Date);
                command.Parameters.AddWithValue("@tarrif", balade.Tarrif);
                command.Parameters.AddWithValue("@depart", balade.Tarrif);
                command.Parameters.AddWithValue("@arrivee", balade.Tarrif);
                command.ExecuteNonQuery();
                Console.WriteLine("save done!");
            }
        }
        public ObservableCollection<Balade> GetAll(string table)
        {

            try
            {
                var querry = $"SELECT * FROM {table}";
                using (SqlCommand command = new SqlCommand(querry,DbConnector.Connection()))
                {
                    DbConnector.Connection().Open();
                    command.CommandText = querry;
                    command.Parameters.Clear();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            long phone;
                            long.TryParse(reader["phone"].ToString(), out phone);
                            datas.Add(new Balade(
                                reader["id_balade"].ToString(),
                                reader["lieu_depart"].ToString(),
                                reader["lieu_arrivee"].ToString(),
                                DateTime.Parse(reader["date_balade"].ToString()),
                                double.Parse(reader["tarrif"].ToString())) );
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

