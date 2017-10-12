using SpaceCats.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaceCats.Web.Controllers
{
    public class SpaceCatsController : Controller
    {
        // GET: SpaceCats
        public ActionResult Index()
        {
            //normally we go to the DAL for this
            List<SpaceCat> model = GetAllSpaceCats();

            return View("Index", model); //<-- Index is the name of Index.cshtml
        }


        public List<SpaceCat> GetAllSpaceCats()
        {
            List<SpaceCat> list = new List<SpaceCat>();
            SpaceCat cat1 = new SpaceCat();
            cat1.Name = "Felix";
            cat1.HomePlanet = "Mars";
            cat1.ImageUrl = "cat_1.jpg";

            SpaceCat cat2 = new SpaceCat();
            cat2.Name = "Elon Meowsk";
            cat2.HomePlanet = "Earth";
            cat2.ImageUrl = "cat_2.jpg";

            SpaceCat cat3 = new SpaceCat();
            cat3.Name = "John Real Quick";
            cat3.HomePlanet = "Saturn";
            cat3.ImageUrl = "cat_3.jpg";

            list.Add(cat1);
            list.Add(cat2);
            list.Add(cat3);

            return list;
        }


    }
}