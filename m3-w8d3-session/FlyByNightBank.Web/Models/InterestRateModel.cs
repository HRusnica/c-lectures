using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlyByNightBank.Web.Models
{
    public class InterestRateModel
    {
        public string ZipCode { get; set; }
        public double SavingsRate { get; set; }
        public double CheckingRate { get; set; }
        public double CDRate { get; set; }
    }
}