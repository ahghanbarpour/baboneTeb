using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using be;
using BLL;
using DAL;
using Dto.Payment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ZarinPal.Class;

namespace BabTeb.Controllers
{
    public class PaymentController : Controller
    {
        private UserManager<UserApp> _usermanager;
        private readonly db _db;
        private readonly Payment _payment;
        private readonly Authority _authority;
        private readonly Transactions _transactions;

        public PaymentController(UserManager<UserApp> usermanager, db db)
        {
            _usermanager = usermanager;
            var expose = new Expose();
            _payment = expose.CreatePayment();
            _authority = expose.CreateAuthority();
            _transactions = expose.CreateTransactions();
            _db = db;
        }
        public async Task<IActionResult> Pay()
        {
            var u = await _usermanager.FindByNameAsync(User.Identity.Name);
            var productIds = new List<int>();
            if (HttpContext.Session.GetString("basket") != null)
            {
                productIds = JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("basket"));
                var blp = new blpackage();
                var products = blp.searchById(productIds);

                blorder blo = new blorder();
                var orderPackages = new List<Order_package>();

                foreach (var item in products)
                {
                    orderPackages.Add(new Order_package { packageId = item.packageId });
                }


                blo.create(new Order
                {
                    Order_Packages = orderPackages,
                    totalPrice = products.Sum(s => s.price),
                    userId = u.Id,
                });

                

            }

            var g = Guid.NewGuid();
            var order = _db.orders.FirstOrDefault();
            order.guid = g;

                var result = await _payment.Request(new DtoRequest()
                {
                    Mobile = order.user.PhoneNumber,
                    CallbackUrl = $"https://www.baboneteb.ir/Payment/Verify?guid={order.guid}",
                    Description = "پرداخت فاکتور شماره:" + order.orderId,
                    Email = order.user.Email,
                    Amount = order.totalPrice,
                    MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX"
                }, ZarinPal.Class.Payment.Mode.sandbox);
                return Redirect($"https://sandbox.zarinpal.com/pg/StartPay/{result.Authority}");


        }
        //[Authorize]
        public IActionResult startTest(string message = null)
        {
            blquestion blq = new blquestion();
            ViewBag.questions = blq.read();

            if (!string.IsNullOrWhiteSpace(message))
            {
                ViewBag.SuccessPayment = message;
            }

            return View();
        }
        [HttpPost]
        public IActionResult startTest(Models.test test)
        {
            bltest blt = new bltest();
            be.test t = new test();

            t.phoneNumber = test.phoneNumber;
            t.age = test.age;
            t.answerId = test.answerId;
            t.packageId = test.packageId;

            blt.create(t);

            ViewBag.link = blt.download(t);

            return RedirectToAction("pay", "profile", new { link = "دانلود فایل" });
        }
        public IActionResult download()
        {
            return View();
        }
        public async Task<IActionResult> Verify(Guid guid, string authority, string status)
        {
            var order = _db.orders.FirstOrDefault();
            order.guid = guid;

            var verification = await _payment.Verification(new DtoVerification
            {
                Amount = order.totalPrice,
                MerchantId = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                Authority = authority
            }, Payment.Mode.sandbox);

            if(verification.Status == 100)
            {
                order.IsFinally = true;
                _db.SaveChanges();
                ViewBag.SuccessPayment = "پرداخت با موفقیت انجام شد.";

                return RedirectToAction("startTest", "payment", new { SuccesPayment = "پرداخت با موفقیت انجام شد." });
            }
            else
            {
                ViewBag.error = "خطا در تراکنش!!!";

                return RedirectToAction("pay", "profile", new { error = "خطا در تراکنش!!!" });
            }


        }
    }
}
