using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MzK_PayU.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Payment()
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes("145227:13a980d4f851f3d9a1cfc792fb1f5e50");
            string my =  System.Convert.ToBase64String(plainTextBytes);

            return View();
        }
        public ActionResult PaymentThanks()
        {
            return View();
        }
    }
}