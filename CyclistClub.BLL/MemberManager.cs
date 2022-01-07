
using CyclistClub.BO;
using CyclistClub.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.BLL
{
    public class MemberManager
    {
        
        public MembreRepository repository;
        public MemberManager()
        {
            repository = new MembreRepository();
        }

        public void AddUser(Membres membres)
        {
            repository.Add(membres);

        }
        public void EditUser()
        {
            //repository.Set(membres);
        }

        public bool EditUser(string Table, string login, string password)
        {
            return repository.Login(Table,login,password);
        }

        //public Membres LoginUser(string email , string password)
        //{
        //    return repository.Login(email,password);
        //}

        public void DeleteUser()
        {
            
        }

        //public List<T> GetAllUsers()
        //{
        //    return repository.GetAll();
        //}
        public  string Md5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x5"));
            }
            return stringBuilder.ToString();
        }


    }
}
