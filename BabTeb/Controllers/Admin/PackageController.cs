using System.Collections.Generic;
using be;
using BLL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace BabTeb.Controllers.Admin
{
    public class PackageController : Controller
    {
        private readonly IWebHostEnvironment Environment;


        public PackageController(IWebHostEnvironment _environment)
        {
            Environment = _environment;
        }

        //[ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public void create(Models.package package)
        {
            blpackage blp = new blpackage();
            be.package p = new be.package();

            p.title = package.title;
            p.descript = package.descript;
            p.price = package.price;
            uploadfile ulf = new uploadfile(Environment);
            p.pic = ulf.upload(package.pic);
            p.warmPdf = ulf.uploadPdf(package.warmPdf);
            p.coldPdf = ulf.uploadPdf(package.coldPdf);

            blp.create(p);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult show()
        {
            blpackage blp = new blpackage();

            return View(blp.read());
        }
        public JsonResult tsjson()
        {
            return Json(new { redirect = "search" });
        }
        public ActionResult Details(int id)
        {
            blpackage blp = new blpackage();
            be.package p = new package();
            p = blp.searchById(id);

            return View(p);
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
            blpackage blp = new blpackage();
            List<package> l1 = blp.search(split);
            return View("show", l1);
        }
        [HttpPost]
        public void update(Models.package package)
        {
            blpackage blp = new blpackage();
            be.package p = new package();

            p.packageId = package.packageId;
            p.title = package.title;
            p.descript = package.descript;
            p.price = package.price;
            uploadfile ulf = new uploadfile(Environment);
            p.pic = ulf.upload(package.pic);
            p.warmPdf = ulf.uploadVideo(package.warmPdf);
            p.coldPdf = ulf.uploadVideo(package.coldPdf);

            blp.update(p);
        }
        [HttpPost]
        public void delete(Models.package package)
        {
            blpackage blp = new blpackage();
            be.package p = new package();

            p.packageId = package.packageId;

            blp.delete(p);
        }
    }
}
