using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mylibraries.Areas.Identity.Data
{
    public class ApplicationUser : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
