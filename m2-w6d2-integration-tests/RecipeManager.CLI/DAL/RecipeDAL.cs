using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeManager.CLI.Models;
using System.Data.SqlClient;

namespace RecipeManager.CLI.DAL
{
    public class RecipeDAL
    {

        private string connectionString;

        public RecipeDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public bool AddRecipe(Recipe r)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO recipe VALUES (@name, @instructions, @description, @cookTime);", conn);
                    cmd.Parameters.AddWithValue("@name", r.Name);
                    cmd.Parameters.AddWithValue("@instructions", r.Instructions);
                    cmd.Parameters.AddWithValue("@description", r.Description);
                    cmd.Parameters.AddWithValue("@cookTime", r.CookTimeInMinutes);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }

            }
            catch(SqlException ex)
            {
                throw;
            }
        }


        public List<Recipe> GetAllRecipes()
        {
            List<Recipe> output = new List<Recipe>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM recipe", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Recipe r = new Recipe();
                        r.Id = Convert.ToInt32(reader["id"]);
                        r.Name = Convert.ToString(reader["name"]);
                        r.Instructions = Convert.ToString(reader["instructions"]);
                        r.Description = Convert.ToString(reader["description"]);
                        r.CookTimeInMinutes = Convert.ToInt32(reader["cookTimeInMinutes"]);

                        output.Add(r);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }

            return output;
        }



    }
}
