using ISEM551_Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISEM551_Assignment2.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            var _entities = new UsersDbContext();
            var model = from _users in _entities.users
                        select _users;
            return View(model.ToList());
        }
    }
}