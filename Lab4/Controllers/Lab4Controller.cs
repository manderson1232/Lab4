using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaffleGenerator;


namespace Lab4.Controllers
{
    public class Lab4Controller : Controller
    {
        public IActionResult Index()
        {
            ViewData["Greeting"] = GetGreeting();
            return View("Index");
        }
        public IActionResult Waffles()
        {
            ViewData["Greeting"] = GetGreeting();
            return View("Waffles");
        }
        public string GetGreeting()
        {
            if (DateTime.Now.Hour < 12)
            {
                return "Good Morning";
            }
            else if (DateTime.Now.Hour < 18)
            {
                return "Good Afternoon";
            }
            else
            {
                return "Good Evening";
            }

        }

    }
}