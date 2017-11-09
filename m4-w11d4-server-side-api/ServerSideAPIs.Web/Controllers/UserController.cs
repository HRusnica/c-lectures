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


        //1. Create an Action to retrieve all users
        [HttpGet] //<-- only allow GET requests
        [Route("users")]
        public ActionResult GetAllUsers()
        {
            //2. Get users from the DAL
            var users = dal.GetAllUsers();
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        //3. Get a single user
        [HttpGet] //<-- only allow GET requests
        [Route("users/{id}")] //<-- can now go to users/1 for user 1 or users/2 for user 2
        public ActionResult GetSingleUser(int id)
        {
            var user = dal.GetUser(id);
            return Json(user, JsonRequestBehavior.AllowGet);
        }


        //5. Add ability to create a user
        [HttpPost]
        [Route("users")]
        public ActionResult CreateAUser(User user)
        {
            dal.AddUser(user);
            return Json(new { result = "OK" });
        }

        //7. Allow us to update a user
        /* PUT and DELETE are not allowed by default. Please use this link to
         * modify the .vs\config\applicationhost.config file to allow it.
         * http://bit.ly/2lY6zY0         
         */
        [HttpPut]
        [Route("users/{id}")]
        public ActionResult UpdateUser(int id, User updatedUser)
        {
            updatedUser.id = id;
            dal.UpdateUser(updatedUser);
            return Json(new { result = "OK" });
        }

        //8. Allow us to delete a user
        [HttpDelete]
        [Route("users/{id}")]
        public ActionResult DeleteUser(int id)
        {
            dal.DeleteUser(id);
            return Json(new { result = "OK" });
        }
    }
}