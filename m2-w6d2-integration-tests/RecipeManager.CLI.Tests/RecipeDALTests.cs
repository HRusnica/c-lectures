using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecipeManager.CLI.Models;
using RecipeManager.CLI.DAL;
using System.Transactions;


namespace RecipeManager.CLI.Tests
{
    [TestClass]
    public class RecipeDALTests
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
        public void AddRecipeToDatabaseTest()
        {
            //Arrange
            // - Fake Recipe
            Recipe r = new Recipe();
            r.CookTimeInMinutes = 10;
            r.Description = "FAKE DESCRIPTION";
            r.Instructions = "FAKE INSTRUCTIONS";
            r.Name = "FAKE NAME";

            // - DAL to Insert the Fake Recipe
            RecipeDAL dal = new RecipeDAL(connectionString);

            //Act
            // - Call AddRecipe using the Fake Recipe
            bool output = dal.AddRecipe(r);

            //Assert
            // - Validatea that AddRecipe returned TRUE
            Assert.IsTrue(output);

        }
    }
}
