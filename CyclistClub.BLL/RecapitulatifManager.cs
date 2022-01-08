using CyclistClub.BO;
using CyclistClub.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.BLL
{
    public class RecapitulatifManager
    {
        RecapitulatifRepository repository;
        public RecapitulatifManager()
        {
            repository = new RecapitulatifRepository();
        }
        public List<Recapitulatif> AfficherRecapitulatif()
        {
            return repository.GetAll();
        }
    }
}
