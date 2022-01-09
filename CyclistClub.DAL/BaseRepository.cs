using CyclistClub.BO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclistClub.DAL
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected ObservableCollection<T> datas;
        string querry;

        public BaseRepository()
        {
            datas = new ObservableCollection<T>();
        }

        //public void GetAll(string table)
        //{

        //    try
        //    {
        //        using (SqlCommand command = new SqlCommand(querry))
        //        {
        //            querry = $"SELECT * FROM {table}";
        //            command.CommandText = querry;
        //            command.Parameters.Clear();

        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    long phone;
        //                    long.TryParse(reader["phone"].ToString(), out phone);
        //                    datas.Add(new Membres(reader["id_membre"].ToString(),reader["name"].ToString(), phone, reader["password"].ToString(), reader["picture"].ToString()));
        //                }
        //                return reader.tli
        //            }
        //        }
                
        //    }
        //    catch
        //    {
        //        //return null;
        //    }

        //}
        public void Set(string table,string rowName, T newValue)
        {
            querry = $"UPDATE  SET )";
            using (SqlCommand command = new SqlCommand(querry))
            {
                DbConnector.Connection().Open();
                command.ExecuteNonQuery();
                Console.WriteLine("save done!");
            }
        }

        public void Delete(string table,string id,string newId)
        {
            querry = $"DELETE FROM{table}  WHERE {id} = {newId})";
            using (SqlCommand command = new SqlCommand(querry))
            {
                DbConnector.Connection().Open();
                command.ExecuteNonQuery();
                Console.WriteLine("save done!");
            }
        }
    }
}
