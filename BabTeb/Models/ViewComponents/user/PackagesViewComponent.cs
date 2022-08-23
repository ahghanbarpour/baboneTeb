using Microsoft.AspNetCore.Mvc;

namespace BabTeb.Models.ViewComponents.user
{
    public class PackagesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BLL.blpackage blp = new BLL.blpackage();
            return View("_packages", blp.read());
        }
    }
}
