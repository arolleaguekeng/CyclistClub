using CyclistClub.BO;
using System;
using System.Collections.Generic;
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
            string query = "INSERT INTO balades(name, date, password,picture)  VALUES(@name, @date, @password,@picture)";
            using (SqlCommand command = new SqlCommand(query))
            {
                DbConnector.Open();
                command.Parameters.AddWithValue("@name", balade.Name);
                command.Parameters.AddWithValue("@date", balade.Date);
                command.Parameters.AddWithValue("@tarrif", balade.Tarrif);
                command.ExecuteNonQuery();
                Console.WriteLine("save done!");
            }

        }
    }
}
