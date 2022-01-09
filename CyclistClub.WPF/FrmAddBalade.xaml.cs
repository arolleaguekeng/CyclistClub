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
    /// Interaction logic for FrmAddBalade.xaml
    /// </summary>
    public partial class FrmAddBalade : Window
    {
        BaladeManager manager;
        public FrmAddBalade()
        {
            manager = new BaladeManager();
            InitializeComponent();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            Balade balade = new Balade("", tbLieuxDepart.Text, tbLieuxArrivee.Text, dtBeginDate.SelectedDate.Value,double.Parse(tbTarrifs.Text));
            manager.AddBalade(balade);
                MessageBox.Show("Ajout effectué !");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
