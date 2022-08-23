using be;
using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BabTeb.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            blquestion blq = new blquestion();
            ViewBag.questions = blq.read();

            blanswer bla = new blanswer();
            ViewBag.answers = bla.read();

            return View();
        }
        [HttpPost]
        public void Index(Models.test test)
        {
            bltest blt = new bltest();
            be.test t = new test();

            t.Equals(test);

            blt.create(t);
        }
        [Authorize(Roles ="Admin")]
        public IActionResult read()
        {
            blorder blo = new blorder();

            return View(blo.getskip(0));
        }
    }
}
