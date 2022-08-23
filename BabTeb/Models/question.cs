using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace BabTeb.Models
{
    public class package
    {
        public int packageId { get; set; }
        public string title { get; set; }
        public string descript { get; set; }
        public IFormFile pic { get; set; }
        public IFormFile warmPdf { get; set; }
        public IFormFile coldPdf { get; set; }
        public List<question> questions { get; set; }
        public List<test> tests { get; set; }
        public int price { get; set; }
    }
    public class question
    {
        public int questionId { get; set; }
        public int answerId { get; set; }
        public int packageId { get; set; }
        public package package { get; set; }
        public string q { get; set; }
        public List<answer> answers { get; set; }
    }
    public class answer
    {
        public int answerId { get; set; }
        public int questionId { get; set; }
        public byte point { get; set; }
        public string a { get; set; }
        public question question { get; set; }
    }
    public class test
    {
        public int testId { get; set; }
        public string phoneNumber { get; set; }
        public byte age { get; set; }
        public int packageId { get; set; }
        public package package { get; set; }
        public List<question> questions { get; set; }
        public int answerId { get; set; }
        public List<answer> answers { get; set; }
    }
}
