using Connexion.DAL;
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
        public enum Mode
        {
            JSON,
            XML,
            BIN
        }



        public void Set(T oldObj)
        {
            querry = $"UPDATE {typeof(T).Name.ToLower()} SET  VALUES({values}))";
        }

        public void Delete(T obj)
        {
            querry = $"DELETE FROM {typeof(T).Name.ToLower()} WHERE {obj.Id}={values})";
        }
    }
}
