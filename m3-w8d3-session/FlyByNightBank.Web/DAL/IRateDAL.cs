using FlyByNightBank.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyByNightBank.Web.DAL
{
    public interface IRateDAL
    {
        InterestRateModel GetRates(string zipcode);
        
    }
}
