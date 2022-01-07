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
        public void AddCotisation(List<string> prop, List<string> value)
        {
            repository = new CotisationRepository();
            //repository.Add(prop,value);
        }
        public void EditUser()
        {
            //repository.Set(membres);
        }
    }
}
