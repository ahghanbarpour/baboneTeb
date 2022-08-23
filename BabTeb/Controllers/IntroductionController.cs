using be;
using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace BabTeb.Controllers
{
    public class IntroductionController : Controller
    {
        private readonly IWebHostEnvironment Environment;


        public IntroductionController(IWebHostEnvironment _environment)
        {
            Environment = _environment;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult addIntro()
        {
            return View();
        }
        [HttpPost]
        public void addIntro(Models.Introduction introduction)
        {
            blintro bli = new blintro();
            be.Introduction i = new Introduction();

            uploadfile ulf = new uploadfile(Environment);
            i.pic = ulf.upload(introduction.pic);
            i.videoIntro = ulf.uploadVideo(introduction.videoIntro);

            bli.addIntro(i);
        }
        public ActionResult Intro(int id)
        {
            blintro bli = new blintro();
            Introduction i = new Introduction();
            i = bli.searchById(id);

            return View(i);
        }
    }
}
