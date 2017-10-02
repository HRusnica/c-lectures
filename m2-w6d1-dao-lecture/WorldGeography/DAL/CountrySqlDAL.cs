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
        

        //Constructor
        public CountrySqlDAL(string databaseconnectionString)
        {
            connectionString = databaseconnectionString;
        }

        // Returns a List<string> that contains the unique continent names in the world database.
        public List<string> GetContinentNames()
        {
            throw new NotImplementedException();
        }


        public List<Country> GetCountriesInNorthAmerica()
        {
            throw new NotImplementedException();
        }
    }
}
