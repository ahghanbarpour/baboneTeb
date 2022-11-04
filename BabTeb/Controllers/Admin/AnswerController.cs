using System.Collections.Generic;
using be;
using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace BabTeb.Controllers.Admin
{
    public class AnswerController : Controller
    {
        [Authorize(Roles = "Admin")]
        public IActionResult create()
        {
            blquestion blq = new blquestion();
            ViewBag.questions = blq.read();

            return View();
        }
        [HttpPost]
        public IActionResult create(Models.answer answer)
        {
            blanswer bla = new blanswer();
            be.answer a = new answer();

            a.questionId = answer.questionId;
            a.a = answer.a;
            a.point = answer.point;

            bla.create(a);

            return RedirectToAction("create","answer");
        }
        [Authorize(Roles = "Admin")]
        public IActionResult show()
        {
            blanswer bla = new blanswer();

            return View(bla.getskip(0));
        }
        public JsonResult tsjson()
        {
            return Json(new { redirect = "search" });
        }
        public IActionResult search(string tags)
        {
            JArray jsonArray = JArray.Parse(tags);
            //dynamic data = JObject.Parse(jsonArray[0].ToString());
            List<string> split = new List<string>();
            foreach (dynamic item in jsonArray)
            {
                split.Add(item.tag.ToString());
            }
            blanswer bla = new blanswer();
            List<answer> l1 = bla.search(split);
            return View("show", l1);
        }
        [HttpPost]
        public void update(Models.answer answer)
        {
            blanswer bla = new blanswer();
            be.answer a = new answer();
            a.answerId = answer.answerId;
            a.question.q = answer.question.q;
            a.a = answer.a;
            a.point = answer.point;

            bla.update(a);
        }
        //[Authorize]
        public IActionResult getskip(int c)
        {
            blanswer bla = new blanswer();
            return View(bla.getskip(c));
        }
    }
}
