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





        // THESE WOULD NORMALLY GO INTO A SpaceCatDAL
        private SpaceCat GetSpaceCat(string id)
        {            
            List<SpaceCat> allSpaceCats = GetAllSpaceCats();

            foreach(var cat in allSpaceCats)
            {
                if(id.ToLower() == cat.Id)
                {
                    return cat; //<-- this cat has the id we need
                }
            }

            return null; //<-- we didn't find the cat with the id we wanted
        }


        private List<SpaceCat> GetAllSpaceCats()
        {
            List<SpaceCat> list = new List<SpaceCat>();
            SpaceCat cat1 = new SpaceCat();
            cat1.Name = "Felix";
            cat1.HomePlanet = "Mars";
            cat1.ImageUrl = "cat_1.jpg";
            cat1.Id = "felix";

            SpaceCat cat2 = new SpaceCat();
            cat2.Name = "Elon Meowsk";
            cat2.HomePlanet = "Earth";
            cat2.ImageUrl = "cat_2.jpg";
            cat2.Id = "elon-meowsk";

            SpaceCat cat3 = new SpaceCat();
            cat3.Name = "John Real Quick";
            cat3.HomePlanet = "Saturn";
            cat3.ImageUrl = "cat_3.jpg";
            cat3.Id = "john-real-quick";
            list.Add(cat1);
            list.Add(cat2);
            list.Add(cat3);

            return list;
        }


    }
}