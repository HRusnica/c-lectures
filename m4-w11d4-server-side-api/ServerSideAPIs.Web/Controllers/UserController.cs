using ServerSideAPIs.Web.DAL;
using ServerSideAPIs.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServerSideAPIs.Web.Controllers
{
    /*
     * This API demonstrates how to develop a server-side API and is used to
     * accompany the topic taught the previous day showing the students
     * how to consume an API. Reference: https://jsonplaceholder.typicode.com/
     */
    public class UserController : Controller
    {
        private IUserDAL dal;
        public UserController(IUserDAL dal)
        {
            this.dal = dal;
        }

        
    }
}