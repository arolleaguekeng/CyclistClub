using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.BO
{
    public class Balade :BaseModel
    {
        public DateTime Date { get; set; }
        public double Tarrif { get; set; }
        public string Name { get; set; }
        public Balade()
        {

        }

        public Balade(string id,string name , DateTime date, double tarrif)
        {
            Id = id;
            Date = date;
            Tarrif = tarrif;
            Name = name;
        }
    }
}
