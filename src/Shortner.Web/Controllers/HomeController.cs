using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Shortner.Web.Data;
using Shortner.Web.Models;

namespace Shortner.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly DbUrlContext dbUrlContext;
        private readonly Settings settings;

        public HomeController(DbUrlContext dbUrlContext, IOptions<Settings> settings)
        {
            this.dbUrlContext = dbUrlContext;
            this.settings = settings.Value;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UrlShortener model)
        {
            var longUrl = new LongUrl
            {
                Url = model.RawUrl,
                Date = DateTime.UtcNow
            };

            await dbUrlContext.AddAsync(longUrl);
            await dbUrlContext.SaveChangesAsync();
            var code = ShortenerCore.Encode(longUrl.Id);

            return PartialView("_ShortUrl", $"{settings.Url}/s/{code}");
        }

        [Route("s/{key}")]
        [HttpGet]
        public async Task<IActionResult> RedirectTo(string key)
        {
            var id = ShortenerCore.Decode(key);
            var longUrl = await dbUrlContext.LongUrls.FindAsync(id);

            return longUrl != null
                ? new RedirectResult(longUrl.Url)
                : (IActionResult)RedirectToAction("Index");
        }
    }
}
