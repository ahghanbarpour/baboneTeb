using Microsoft.AspNetCore.Http;

namespace BabTeb.Models
{
    public class Introduction
    {
        public int id { get; set; }
        public IFormFile pic { get; set; }
        public IFormFile videoIntro { get; set; }
    }
}
