using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ISTA322_Lab7A;
using ISTA322_Lab7A.Models;

namespace ISTA322_Lab7A.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            string timeOfDay;

            if(hour < 12)
            {
                timeOfDay = "Good Morning";
            }
            else if(hour < 18)
            {
                timeOfDay = "Good Afternoon";
            }
            else
            {
                timeOfDay = "Good Evening";
            }

            ViewBag.Greeting = timeOfDay;
            return View();
        }
        
        [HttpGet]
        public ViewResult RSVPForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RSVPForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //TODO: Email response to the party organizer
                return View("Thanks", guestResponse);
            }
            else
            {
                //there is a validation error
                return View();
            }

        }
    }
}