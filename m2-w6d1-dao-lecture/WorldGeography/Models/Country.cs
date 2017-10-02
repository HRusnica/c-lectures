using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldGeography.Models
{
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public string Region { get; set; }
        public double SurfaceArea { get; set; }
        public int IndependenceYear { get; set; }
        public int Population { get; set; }
        public double? LifeExpectancy { get; set; } //<-- nullable property, it can have a value that is a double or NULL if there is no known life expectancy
        public decimal? GNP { get; set; } //<-- nullable property, it can have a value that is a decimal or NULL if there is no value
        public string LocalName { get; set; }
        public string GovernmentForm { get; set; }
        public string HeadOfState { get; set; }
        public int? CapitalId { get; set; } //<-- nullable property, it can have a value that is a int or NULL if there is no value
        public string Code2 { get; set; }

        
    }
}
