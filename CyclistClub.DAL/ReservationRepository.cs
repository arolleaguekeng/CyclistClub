using CyclistClub.BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.DAL
{
    public class ReservationRepository : BaseRepository<Reservation>
    {
        public void Add(Membres membres)
        {

            string query = "INSERT INTO reservation(name, id_client, type_reservation)  VALUES(@name, @client, @type)";
            using (SqlCommand command = new SqlCommand(query))
            {
                DbConnector.Open();
                command.Parameters.AddWithValue("@name", membres.FullName);
                command.Parameters.AddWithValue("@client", membres.PhoneNumber);
                command.Parameters.AddWithValue("@type", membres.Password);
                command.ExecuteNonQuery();
                Console.WriteLine("save done!");
            }

        }
    }
}
