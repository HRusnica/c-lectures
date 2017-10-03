using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeManager.CLI.DAL;
using RecipeManager.CLI.Models;

namespace RecipeManager.CLI
{
    public class RecipeCLI
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=cookbook;User ID=te_student;Password=sqlserver1";

        public void Run()
        {

            while(true)
            {
                Console.Clear();
                Console.WriteLine(@"                                                   ");
                Console.WriteLine(@" (    (             (             (   (       (    ");
                Console.WriteLine(@" )\ ) )\ )  *   )   )\ )      (   )\ ))\ )    )\ ) ");
                Console.WriteLine(@"(()/((()/(` )  /(  (()/((     )\ (()/(()/((  (()/( ");
                Console.WriteLine(@" /(_))/(_))( )(_))  /(_))\  (((_) /(_))(_))\  /(_))");
                Console.WriteLine(@"(_)) (_)) (_(_())  (_))((_) )\___(_))(_))((_)(_))  ");
                Console.WriteLine(@"| |  |_ _||_   _|  | _ \ __((/ __|_ _| _ \ __/ __| ");
                Console.WriteLine(@"| |__ | |   | |    |   / _| | (__ | ||  _/ _|\__ \ ");
                Console.WriteLine(@"|____|___|  |_|    |_|_\___| \___|___|_| |___|___/ ");

                Console.WriteLine();
                Console.WriteLine("1 - Show all recipes");
                Console.WriteLine("2 - Add a recipe");
                Console.WriteLine("3 - Add ingredients");
                Console.WriteLine("Q - QUIT");

                string input = CLIHelper.GetString("Make a choice");

                switch (input.ToLower())
                {
                    case "1":
                        ShowAllRecipes();
                        break;

                    case "2":
                        AddARecipe();
                        break;

                    case "3":
                        AddIngredient();
                        break;

                    case "q":
                        Console.WriteLine("QUITTER");
                        Console.ReadLine();
                        return;
                }


            }
        }

        private void ShowAllRecipes()
        {
            Console.WriteLine("SHOWING RECIPES");

            RecipeDAL dal = new RecipeDAL(connectionString);

            List<Recipe> allRecipes = dal.GetAllRecipes();

            foreach(Recipe r in allRecipes)
            {
                Console.WriteLine();
                Console.WriteLine(r.Id + ")" + r.Name + " - " + r.CookTimeInMinutes + " minutes");
                Console.WriteLine("DESCRIPTION: " + r.Description);

                IngredientDAL ingredientDal = new IngredientDAL(connectionString);

                List<Ingredient> recipeIngredients = ingredientDal.GetIngredientsForRecipe(r.Id);

                Console.WriteLine("INGREDIENTS");
                foreach (Ingredient i in recipeIngredients)
                {                    
                    Console.WriteLine(" - " + i.Name + " (" + i.Quantity + ")");
                }

            }

            Console.ReadLine();
        }

        private void AddARecipe()
        {
            string name = CLIHelper.GetString("NAME OF RECIPE: ");
            string description = CLIHelper.GetString("DESCRIPTION: ");
            string instructions = CLIHelper.GetString("INSTRUCTIONS: ");
            int cookTime = CLIHelper.GetInteger("How long does it take to cook");

            Recipe r = new Recipe();
            r.Name = name;
            r.Description = description;
            r.Instructions = instructions;
            r.CookTimeInMinutes = cookTime;

            RecipeDAL dal = new RecipeDAL(connectionString);
            dal.AddRecipe(r);


            Console.WriteLine("Sucessfully added!");

            Console.ReadLine();
        }

        private void AddIngredient()
        {
            string name = CLIHelper.GetString("What is the ingredient");
            string quantity = CLIHelper.GetString($"How much of {name}");
            int recipeId = CLIHelper.GetInteger("Which recipe is it for");

            Ingredient i = new Ingredient();
            i.Name = name;
            i.Quantity = quantity;
            i.RecipeId = recipeId;

            IngredientDAL dal = new IngredientDAL(connectionString);

            dal.AddIngredient(i);

            Console.WriteLine("SUCCESS");

            Console.ReadLine();
        }

    }
}
