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
        private const string SQL_InsertLanguage = @"insert into countrylanguage values (@countryCode, @language, @isOfficial, @percentage);";

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
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_InsertLanguage, conn);
                    cmd.Parameters.AddWithValue("@countryCode", newLanguage.CountryCode);
                    cmd.Parameters.AddWithValue("@language", newLanguage.Name);
                    cmd.Parameters.AddWithValue("@isOfficial", newLanguage.IsOfficial);
                    cmd.Parameters.AddWithValue("@percentage", newLanguage.Percentage);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0); //true if one row was affected
                }
            }
            catch (SqlException ex)
            {
                //log
                throw;
            }
        }

        public bool RemoveLanguage(Language deadLanguage)
        {
            throw new NotImplementedException();
        }
    }
}
