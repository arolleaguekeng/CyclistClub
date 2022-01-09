using CyclistClub.BLL;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CyclistClub.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MemberManager manager;
        public MainWindow()
        {
            manager = new MemberManager();
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (manager.LoginUser(tbEmail.Text, tbPassword.Password.ToString()) == true)
                {
                    FrmInscription frmAdd = new FrmInscription();
                    frmAdd.Show();
                }
                else
                {
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorect")
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
