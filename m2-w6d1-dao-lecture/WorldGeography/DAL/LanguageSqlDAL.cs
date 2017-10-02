using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class LanguageSqlDAL
    {
        private string connectionString;        

        public LanguageSqlDAL(string databaseConnectionString)
        {
            connectionString = databaseConnectionString;
        }

        public List<Language> GetLanguages(string countryCode)
        {
            throw new NotImplementedException();
        }

        public bool AddNewLanguage(Language newLanguage)
        {
            throw new NotImplementedException();
        }

        public bool RemoveLanguage(Language deadLanguage)
        {
            throw new NotImplementedException();
        }
    }
}
