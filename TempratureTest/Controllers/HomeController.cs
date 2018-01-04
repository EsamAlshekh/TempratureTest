
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TemperatureTest.Models;

namespace TemperatureTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        // GET: Home
        [HttpGet]
        public ViewResult RsvpForm()
        {

            return View();
        }

        [HttpPost]

        public ViewResult RsvpForm(Person person)
        {
            
            if (ModelState.IsValid)
                {
                ViewBag.TestMessage = Person.Theresult(person.Temperature);
                return View("Result", person);
                //    if (person.Temperature == 37)
                //    {
                //        ViewBag.TestMessage = "Great!you are ok ,And your temperature is normal.";
                //    }
                //    else if (person.Temperature < 37)
                //    {
                //        ViewBag.TestMessage = "Your temperature is not low ,you have to visit the doctor.";
                //    }
                //    else
                //    {
                //        ViewBag.TestMessage = "Your temperature is not high ,you have to visit the doctor.";
                //    }
                //    return View("Result", person);
                }
            else
            {
                return View();
            }
            // -----------------------------------------
            //if (ModelState.IsValid)
            //{
            //    return View("Result", person);
            //}
            //else
            //{
            //    return View();
            //}

        }

    }
}