using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BabTeb.Controllers
{
    public class OrderController : Controller
    {
        public async Task<IActionResult> AddTOBasket(int packageId)
        {
            var basketList = new List<int>();

            if (HttpContext.Session.GetString("basket") != null)
            {
                basketList =
                    JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("basket")).ToList();
            }

            basketList.Add(packageId);

            HttpContext.Session.SetString("basket", JsonConvert.SerializeObject(basketList));

            return RedirectToAction("details", "package", new { id = packageId });
        }
        public IActionResult ClearBasket()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("pay", "Profile");
        }
    }
}
