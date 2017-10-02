using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public class CountrySqlDAL 
    {
        private string connectionString;
        private const string SQL_GetContinentNames = "SELECT DISTINCT continent FROM country";

        //Constructor
        public CountrySqlDAL(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        // Returns a List<string> that contains the unique continent names in the world database.
        public List<string> GetContinentNames()
        {
            List<string> output = new List<string>();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = SQL_GetContinentNames;
                    cmd.Connection = connection;

                    //Execute the query
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string continent = Convert.ToString(reader["continent"]);
                        output.Add(continent);
                    }

                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return output;
        }


        public List<Country> GetCountriesInNorthAmerica()
        {
            List<Country> output = new List<Country>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM country WHERE continent='North America'", conn);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Country c = new Country();
                        c.Code = Convert.ToString(reader["code"]);
                        c.Name = Convert.ToString(reader["name"]);
                        c.Continent = Convert.ToString(reader["continent"]);
                        c.Region = Convert.ToString(reader["region"]);
                        c.SurfaceArea = Convert.ToDouble(reader["surfacearea"]);
                        c.Population = Convert.ToInt32(reader["population"]);
                        c.GovernmentForm = Convert.ToString(reader["governmentform"]);
                        output.Add(c);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return output;
        }
    }
}
