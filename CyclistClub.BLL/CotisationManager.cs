using CyclistClub.BO;
using CyclistClub.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.BLL
{
    public class CotisationManager
    {
        CotisationRepository repository;
        public CotisationManager()
        {
            repository = new CotisationRepository();
        }
        
        public void AddCotisation(Cotisation cotisation)
        {

            repository.Add(cotisation);
        }
        //public void AfficherCotisations()
        //{
        //    repository.GetAll("cotisations");
        //}
    }
}
