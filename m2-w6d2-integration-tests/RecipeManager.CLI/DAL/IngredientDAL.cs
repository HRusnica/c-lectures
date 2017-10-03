using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeManager.CLI.Models;
using System.Data.SqlClient;


namespace RecipeManager.CLI.DAL
{
    public class IngredientDAL
    {

        private string connectionString;

        public IngredientDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AddIngredient(Ingredient i)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO ingredients VALUES (@name, @quantity, @recipeId);", conn);
                    cmd.Parameters.AddWithValue("@name", i.Name);
                    cmd.Parameters.AddWithValue("@quantity", i.Quantity);
                    cmd.Parameters.AddWithValue("@recipeId", i.RecipeId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return (rowsAffected > 0);
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
        }



        public List<Ingredient> GetIngredientsForRecipe(int recipeId)
        {
            List<Ingredient> output = new List<Ingredient>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM ingredients WHERE recipeId = @recipeId", conn);
                    cmd.Parameters.AddWithValue("@recipeId", recipeId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Ingredient i = new Ingredient();
                        i.Id = Convert.ToInt32(reader["id"]);
                        i.Name = Convert.ToString(reader["name"]);
                        i.Quantity = Convert.ToString(reader["quantity"]);
                        i.RecipeId = Convert.ToInt32(reader["recipeId"]);

                        output.Add(i);
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