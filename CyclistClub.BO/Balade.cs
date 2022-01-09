using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.BO
{
    public class Balade :BaseModel
    {
        public string LieuDepart { get; set; }
        public string LieuArrive { get; set; }
        public DateTime Date { get; set; }
        public double Tarrif { get; set; }
        public Balade()
        {

        }

        public Balade(string id,string lieuDepart, string lieuArrive, DateTime date, double tarrif)
        {
            Id = id;
            LieuDepart = lieuDepart;
            LieuArrive = lieuArrive;
            Date = date;
            Tarrif = tarrif;
        }
    }
}
