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
    /// Interaction logic for FrmAddMembre.xaml
    /// </summary>
    public partial class FrmAddMembre : Window, INotifyPropertyChanged
    {
        MemberManager manager;
        Membres membres;
        OpenFileDialog op;
        public FrmAddMembre()
        {
            op = new OpenFileDialog();
            InitializeComponent();
            manager = new MemberManager();
        }

        public event PropertyChangedEventHandler PropertyChanged;


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MD5 mD5 = MD5.Create();
                membres = new Membres(0,txtFullname.Text, int.Parse(txtPhoneNumber.Text.ToString()),
                    txtEmail.Text.ToString(), manager.Md5Hash(mD5,txtPassword.Password),op.FileName);
                manager.AddUser(membres);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnAddPicture_Click(object sender, RoutedEventArgs e)
        {
            
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                membres.Email = "";
                membres.FullName = "";
                membres.Picture = op.FileName;
                imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
            }

        }
    }
}
