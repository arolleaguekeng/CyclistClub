using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.BO
{
    public class BaseModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string id;
        public string Id
        {
            get => id;
            set
            {
                id = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Id)));
            }
        }

        public BaseModel()
        {

        }
    }
}
