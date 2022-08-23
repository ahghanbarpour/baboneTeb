using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BabTeb.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult pay(string link = null)
        {

            if (!string.IsNullOrWhiteSpace(link))
            {
                ViewBag.link = link;
            }

            return View();
        }
    }
}
