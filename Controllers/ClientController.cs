using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace View_Data.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            // Send Simple Data
            base.ViewData["Name"] = "Vinit SUryarao";
            base.ViewData["Age"] = 25;

            return View();
        }
    }
}