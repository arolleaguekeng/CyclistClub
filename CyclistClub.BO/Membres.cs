using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.BO
{
    public class Membres : BaseModel
    {

        public string email;
        public event PropertyChangedEventHandler PropertyChanged;

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
        public long phoneNumber;
        public long PhoneNumber
        {
            get => phoneNumber;
            set
            {
                phoneNumber = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PhoneNumber)));
            }
        }

        public string password;
        public string Password
        {
            get => password;
            set
            {
                password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password)));
            }
        }


        public string picture;
        public string Picture
        {
            get => picture;
            set
            {
                picture = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Picture)));
            }
        }
        public Membres(string id,  string fullName, long phoneNumber, string password,string picture)
        {
            Email = email;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Password = password;
            Id = id;
            Picture = picture;
        }

        public Membres()
        {
        }
    }
}
