using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeManager.CLI.Models;
using RecipeManager.CLI.DAL;
using System.Transactions;
using System.Data.SqlClient;


namespace RecipeManager.CLI.Tests
{
    [TestClass]
    public class IngredientDALTests
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=cookbook;User ID=te_student;Password=sqlserver1";
        TransactionScope t;

        [TestInitialize]
        public void Initialize()
        {
            // Code that runs before each test
            // Begin a new transaction
            t = new TransactionScope();
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Code that runs after each test
            // Rollback the transaction by calling .Dispose()
            t.Dispose();
        }

        [TestMethod]
        public void AddIngredientToExistingRecipe()
        {
            // Arrange
            // - Add a Recipe so that we can add ingredients
            //      - Write SQL code to Insert FAKE RECIPE
            int recipeId;

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO recipe VALUES ('Fake Recipe', 'Fake Instructions', 'Fake Description', 0);", conn);
                cmd.ExecuteNonQuery();

                //      - Get new recipe Id with SELECT SCOPE_IDENTITY()
                cmd = new SqlCommand("SELECT CAST(SCOPE_IDENTITY() as int);", conn);
                recipeId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            // - Create an ingredient to add
            Ingredient i = new Ingredient();
            i.Name = "FAKE INGREDIENT";
            i.Quantity = "FAKE QUANTITY";
            i.RecipeId = recipeId;

            // - Create the ingredient DAL
            IngredientDAL dal = new IngredientDAL(connectionString);

            // Act
            // - Call AddIngredient in the IngredientDAL
            bool output = dal.AddIngredient(i);


            // Assert
            // - Validate we received TRUE from AddIngredient
            Assert.IsTrue(output);

        }
    }
}
