using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlyByNightBank.Web.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace FlyByNightBank.Web.DAL
{
    public class RateSqlDAL : IRateDAL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["FlyByNightBankDB"].ConnectionString;


        public InterestRateModel GetRates(string zipcode)
        {
            InterestRateModel output = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM rates WHERE zip_code = @zipCode", conn);
                    cmd.Parameters.AddWithValue("@zipCode", zipcode);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        output = new InterestRateModel();
                        output.ZipCode = Convert.ToString(reader["zip_code"]);
                        output.SavingsRate = Convert.ToDouble(reader["savings_rate"]);
                        output.CheckingRate= Convert.ToDouble(reader["checking_rate"]);
                        output.CDRate = Convert.ToDouble(reader["cd_rate"]);
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