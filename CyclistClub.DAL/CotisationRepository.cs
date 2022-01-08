using CyclistClub.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.DAL
{
    public class CotisationRepository : BaseRepository<Cotisation>
    {
        public void Add(Membres membres)
        {

            string query = "INSERT INTO cotisation(date, montent)  VALUES(@date, @montent)";
            using (SqlCommand command = new SqlCommand(query))
            {
                DbConnector.Open();
                command.Parameters.AddWithValue("@date", membres.FullName);
                command.Parameters.AddWithValue("@montent", membres.PhoneNumber);
                command.ExecuteNonQuery();
                Console.WriteLine("save done!");
            }

        }
    }
}
