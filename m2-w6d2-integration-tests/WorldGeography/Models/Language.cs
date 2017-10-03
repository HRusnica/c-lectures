using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldGeography.Models
{
    public class Language
    {        
        public string Name { get; set; }
        public bool IsOfficial { get; set; }
        public int Percentage { get; set; }
        public string CountryCode { get; set; }

        
    }
}
