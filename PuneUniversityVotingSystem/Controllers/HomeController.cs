using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PuneUniversityVotingSystem.Data;
using PuneUniversityVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PuneUniversityVotingSystem.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Users user1)
        {
            using (_db)
            {
                var user = _db.User.Where(u => u.Email == user1.Email && u.Password == user1.Password);
                if (user != null)
                {
                    if (user1.RoleId == 1)
                    {

                        return RedirectToAction("AdminDashbord");
                    }
                    else
                    {
                       return RedirectToAction("UserDashbord");

                    }
                }
            }
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Users list)
        {
            if (ModelState.IsValid)
            {
              
                using (_db)
                {
                    list.RoleId = 2;
                    _db.User.Add(list);
                    _db.SaveChanges();
                }
             
                ViewBag.Message = list.UserName + " " + " Registered";
                ModelState.Clear();
            }
            return View();


        }
        public IActionResult UserDashbord()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
