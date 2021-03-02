using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHamzaBookStore.Controllers
{
    public class HomeController : Controller
    {
        public string index()
        {
            return "Hello from controller";
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
