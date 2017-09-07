using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shortner.Web.Models;

namespace Shortner.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UrlShortener model)
        {
            model = model ?? new UrlShortener();
            model.ShortUrl = "abcd";
            return PartialView("_UrlShortener", model);
        }
        
    }
}
