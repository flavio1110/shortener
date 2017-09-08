using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shortner.Web.Data;
using Shortner.Web.Models;

namespace Shortner.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbUrlContext dbUrlContext;

        public HomeController(DbUrlContext dbUrlContext)
        {
            this.dbUrlContext = dbUrlContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UrlShortener model)
        {
            model = model ?? new UrlShortener();
            model.ShortUrl = "abcd";

            await dbUrlContext.AddAsync(new LongUrl
            {
                Url = model.RawUrl,
                Date = DateTime.UtcNow
            });
            await dbUrlContext.SaveChangesAsync();

            return PartialView("_UrlShortener", model);
        }
        
    }
}
