using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.BO
{
    public class Reservation : BaseModel
    {
        public int Id_membre { get; set; }
        public string TypeReservation { get; set; }
        public string Name { get; set; }
        public int Velo { get; set; }
        public int membre { get; set; }

        public Reservation(string id,int id_membre,int velo, int membre)
        {
            Id_membre = id_membre;
            Velo = velo;
            this.membre = membre;
            Id = id;
        }
    }
}
