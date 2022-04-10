using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Controllers
{
    public class UserControllerVladislaw : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserViewModel user)
        {
            return View("Greetings", user);
        }

    }
}
