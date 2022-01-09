using CyclistClub.BLL;
using CyclistClub.BO;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for FrmReservation.xaml
    /// </summary>
    public partial class FrmReservation : Window
    {
        ReservationManager manager;
        public FrmReservation()
        {
            InitializeComponent();
            manager = new ReservationManager();
        }

        private void bntSave_Click(object sender, RoutedEventArgs e)
        {
            Reservation reservation = new Reservation("",1,int.Parse(tbNbreplaceVelo.Text),int.Parse(tbNbrePlaceMembre.Text ));
            Application.Current.Properties.Add("reservation", reservation);

        }
    }
}
