using CyclistClub.BLL;
using CyclistClub.BO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CyclistClub.WPF
{
    /// <summary>
    /// Interaction logic for FrmshowBalade.xaml
    /// </summary>
    public partial class FrmshowBalade : Window, INotifyPropertyChanged
    {
        //string lieuDepart, string lieuArrive, DateTime date, double tarrif
        private string lieuDepart;
        public string LieuDepart
        {
            get => lieuDepart;
            set
            {
                lieuDepart = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LieuDepart)));
            }
        }
        public string lieuArrivee;

        public event PropertyChangedEventHandler PropertyChanged;

        public string LieuArrivee
        {
            get => lieuArrivee;
            set
            {
                lieuArrivee = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LieuArrivee)));
            }
        }
        BaladeManager manager;
        ObservableCollection<Balade> balade;
        public FrmshowBalade()
        {
            balade = new ObservableCollection<Balade>();
            InitializeComponent();
            manager = new BaladeManager();
            balade = manager.GetAllBalade();
            DataContext = this;


        }
    }
}
