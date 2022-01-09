using CyclistClub.BLL;
using CyclistClub.BO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for FrmInscription.xaml
    /// </summary>
    public partial class FrmInscription : Window
    {
        MemberManager manager;
        CotisationManager c_manager;
        Membres membres;
        OpenFileDialog op;
        public FrmInscription()
        {
            membres = new Membres();
            c_manager = new CotisationManager();
            op = new OpenFileDialog();
            manager = new MemberManager();
            InitializeComponent();

        }

        public event PropertyChangedEventHandler PropertyChanged;


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                MD5 mD5 = MD5.Create();
                membres = new Membres("", txtFullname.Text, int.Parse(txtPhoneNumber.Text.ToString()),
                    manager.Md5Hash(mD5, txtPassword.Password), op.FileName);
                manager.AddUser(membres);
                c_manager.AddCotisation(new Cotisation("", double.Parse(tbMontentCotisation.Text), DateTime.Now, membres.Id));
                MessageBox.Show(membres.FullName);
            //membres.Email = "";
            //membres.FullName = "";

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}


        private void btnAddPicture_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                op.Title = "Select a picture";
                op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
                  "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                  "Portable Network Graphic (*.png)|*.png";
                if (op.ShowDialog() == true)
                {
                    membres.Picture = op.FileName;
                    imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }


    }
}
