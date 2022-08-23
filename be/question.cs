using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace be
{
    public class package
    {
        [Key]
        public int packageId { get; set; }
        public string title { get; set; }
        public string descript { get; set; }
        public byte pointLine { get; set; }
        public string pic { get; set; }
        public string warmPdf { get; set; }
        public string coldPdf { get; set; }
        public List<question> questions { get; set; }
        public List<test> tests { get; set; }
        public int price { get; set; }
        public List<Order_package> Order_Packages { get; set; }
    }
    public class question
    {
        [Key]
        public int questionId { get; set; }
        public int answerId { get; set; }
        public int packageId { get; set; }
        public package package { get; set; }
        public test test { get; set; }
        public string q { get; set; }
        public List<answer> answers { get; set; }
    }
    public class answer
    {
        [Key]
        public int answerId { get; set; }
        public int questionId { get; set; }
        public byte point { get; set; }
        public string a { get; set; }
        public question question { get; set; }
        public test test { get; set; }
    }
    public class test
    {
        [Key]
        public int testId { get; set; }
        public string phoneNumber { get; set; }
        public byte age { get; set; }
        public int packageId { get; set; }
        public package package { get; set; }
        public List<question> questions { get; set; }
        public int answerId { get; set; }
        public List<answer> answers { get; set; }
    }
    public class UserApp : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Order
    {
        [Key]
        public int orderId { get; set; }
        public int packageId { get; set; }
        public string userId { get; set; }
        public UserApp user { get; set; }
        public Guid guid { get; set; }
        public int totalPrice { get; set; }
        public List<Order_package> Order_Packages { get; set; }
        public bool IsFinally { get; set; }
    }
    public class Order_package
    {
        [Key]
        public int id { get; set; }
        public int orderId { get; set; }
        public int packageId { get; set; }
        public Order Order { get; set; }
        public package package { get; set; }
    }
}
