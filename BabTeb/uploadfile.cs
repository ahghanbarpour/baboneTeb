using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace BabTeb
{
    public class uploadfile
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public uploadfile(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public string upload(IFormFile file)
        {
            if (file == null) return "";
            var path = _webHostEnvironment.WebRootPath + "\\assets\\images\\photos\\" + file.FileName;
            using var f = System.IO.File.Create(path);
            file.CopyTo(f);

            //for video
            //path = path.Split("wwwroot")[1];

            return file.FileName;
        }
        public string uploadVideo(IFormFile file)
        {
            if (file == null) return "";
            var path = _webHostEnvironment.WebRootPath + "\\assets\\videos\\" + file.FileName;
            using var f = System.IO.File.Create(path);
            file.CopyTo(f);

            path = path.Split("wwwroot")[1];

            return file.FileName;
        }
        public string uploadPdf(IFormFile file)
        {
            if (file == null) return "";
            var path = _webHostEnvironment.WebRootPath + "\\assets\\PDFs\\" + file.FileName;
            using var f = System.IO.File.Create(path);
            file.CopyTo(f);

            return file.FileName;
        }
    }
}
