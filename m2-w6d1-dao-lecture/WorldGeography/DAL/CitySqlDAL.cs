using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CitySqlDAL
    {        
        private string connectionString;
        private const string SQL_CountryCodeCites = "SELECT * FROM city WHERE countryCode = @countrycode ORDER BY district, name;";
        public CitySqlDAL(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }


        public List<City> GetCitiesByCountryCode(string countryCode)
        {
            List<City> output = new List<City>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(SQL_CountryCodeCites, conn);

                    cmd.Parameters.AddWithValue("@countrycode", countryCode);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        City c = new City();
                        c.CityId = Convert.ToInt32(reader["id"]);
                        c.Name = Convert.ToString(reader["name"]);
                        c.CountryCode = Convert.ToString(reader["countrycode"]);
                        c.District = Convert.ToString(reader["district"]);
                        c.Population = Convert.ToInt32(reader["population"]);

                        output.Add(c);
                    }
                }
            }
            catch (SqlException ex)
            {
                //Log and throw the exception
                throw;
            }

            return output;
        }

    }
}
