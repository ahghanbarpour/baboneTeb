using be;
using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BabTeb.Controllers.Admin
{
    public class QuestionController : Controller
    {
        [Authorize(Roles = "Admin")]
        public IActionResult create()
        {
            blpackage blp = new blpackage();
            ViewBag.packages = blp.read();

            return View();
        }
        [HttpPost]
        public void create(Models.question question)
        {
            blquestion blq = new blquestion();
            be.question q = new question();

            q.packageId = question.packageId;
            q.q = question.q;

            blq.create(q);
        }
    }
}
