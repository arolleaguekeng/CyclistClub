using CyclistClub.BO;
using System;
using System.Collections.Generic;
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
        protected List<T> datas;
        string querry;
        string properties;
        string values;

        public BaseRepository()
        {
            datas = new List<T>();
        }

        public SqlDataReader GetAll(string table)
        {

            try
            {
                using (SqlCommand command = new SqlCommand(querry))
                {
                    querry = $"SELECT * FROM {table}";
                    command.CommandText = querry;
                    command.Parameters.Clear();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            datas.Add();
                        }
                        return reader.tli
                    }
                }
                
            }
            catch
            {
                return null;
            }

        }
        public void Set(string table,string rowName, T newValue)
        {
            querry = $"UPDATE  SET )";
            using (SqlCommand command = new SqlCommand(querry))
            {
                DbConnector.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("save done!");
            }
        }

        public void Delete(string table,string id,string newId)
        {
            querry = $"DELETE FROM{table}  WHERE {id} = {newId})";
            using (SqlCommand command = new SqlCommand(querry))
            {
                DbConnector.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("save done!");
            }
        }
    }
}
