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
        public void Add(Cotisation cotisation)
        {

            string query = "INSERT INTO cotisations(montent,date_cotisation,id_membre)  VALUES(@date, @montent,@id_utilisateur)";
            using (SqlCommand command = new SqlCommand(query))
            {
                DbConnector.Connection().Open();
                command.Parameters.AddWithValue("@date", cotisation.Id);
                command.Parameters.AddWithValue("@montent", cotisation.Montent);
                command.Parameters.AddWithValue("@id_utilisateur", cotisation.IdUtilisateur);
                command.ExecuteNonQuery();
                Console.WriteLine("save done!");
            }

        }
    }
}
