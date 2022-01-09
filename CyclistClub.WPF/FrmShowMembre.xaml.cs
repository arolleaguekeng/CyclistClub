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
    /// Interaction logic for FrmShowMembre.xaml
    /// </summary>
    public partial class FrmShowMembre : Window, INotifyPropertyChanged
    {

        public ObservableCollection<Membres> membres { get; set; }
        public string email;
        public event PropertyChangedEventHandler PropertyChanged;
        MemberManager manager;
        public string Email
        {
            get => email;
            set
            {
                email = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
            }
        }
        public string fullname;
        public string FullName
        {
            get => fullname;
            set
            {
                fullname = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FullName)));
            }
        }

        public FrmShowMembre()
        {
            manager = new MemberManager();
            membres = manager.GetAllUsers();
            DataContext = this;

            membres = new ObservableCollection<Membres>();
            InitializeComponent();
            
        }
    }
}
