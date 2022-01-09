using CyclistClub.BO;
using CyclistClub.DAL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.BLL
{
    public class BaladeManager
    {
        BaladeRepository repository;
        public BaladeManager()
        {
            repository = new BaladeRepository();
        }
        public void AddBalade(Balade balade)
        {
            repository.Add(balade);
        }
        public ObservableCollection<Balade> GetAllBalade()
        {
            return repository.GetAll("balades");
        }
    }
}
