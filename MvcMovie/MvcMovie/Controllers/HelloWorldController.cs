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
        public string Index()
        {
            //return View();
            return "This is my default action...";
        }

        public string Welcome(string name, int numTimes = 1)
        {
            //return "This is the Welcome action method...";
            return $"Hello {name}, numTimes: {numTimes}";
        }

    }
}