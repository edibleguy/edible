using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebHelloWorld.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "This message defined in Controllers_HomeController.cs";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
