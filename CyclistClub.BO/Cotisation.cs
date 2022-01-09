using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.BO
{
    public class Cotisation : BaseModel
    {
        public double Montent { get; set; }
        public DateTime Date { get; set; }
        public string IdUtilisateur { get; set; }

        public Cotisation(string id,double montent, DateTime date, string idUtilisateur)
        {
            Montent = montent;
            Date = date;
            IdUtilisateur = idUtilisateur;
            Id = id; 
        }
    }
}
