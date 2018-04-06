using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TennApp.Models;

namespace TennApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        public IActionResult Reports()
        {
            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}