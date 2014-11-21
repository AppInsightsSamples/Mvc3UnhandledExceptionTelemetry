using System;
using System.Web.Mvc;
using MVC3App.Models;

namespace MVC3App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View();
        }

        public ActionResult About()
        {
            var r = new Random();
            if (r.Next() % 3 == 0)
            {
                var c = new AboutModel();
                c.saySomething();
            }
            return View();
        }
    }
}
