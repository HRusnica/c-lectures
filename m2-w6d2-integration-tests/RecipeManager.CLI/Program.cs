using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeManager.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            RecipeCLI r = new RecipeCLI();
            r.Run();
        }
    }
}
