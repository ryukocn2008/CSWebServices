using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
            //return "This is my default action...";
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            //return "This is the Welcome action method...";
            //return $"Hello {name}, numTimes: {numTimes}";
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}