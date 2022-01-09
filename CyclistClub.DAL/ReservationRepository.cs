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
        public void Add(Reservation reservation)
        {

            string query = "INSERT INTO reservation(id_membre, velo,membre)  VALUES(@client, @velo,@membre)";
            using (SqlCommand command = new SqlCommand(query))
            {
                DbConnector.Connection().Open();
                command.Parameters.AddWithValue("@client", reservation.Id_membre);
                command.Parameters.AddWithValue("@velo", reservation.TypeReservation);
                command.Parameters.AddWithValue("@membre", reservation.TypeReservation);
                command.ExecuteNonQuery();
                Console.WriteLine("save done!");
            }
        }
    }
}
