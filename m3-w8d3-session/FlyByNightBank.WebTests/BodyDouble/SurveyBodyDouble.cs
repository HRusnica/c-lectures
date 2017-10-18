using FlyByNightBank.Web.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyByNightBank.Web.Models;

namespace FlyByNightBank.WebTests.BodyDouble
{
    public class SurveyBodyDouble : ISurveyDAL
    {
        public bool SaveSurvey(Survey newSurvey)
        {
            return true;
        }
    }
}
