using System;
using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Poll(Polling guestResponse)
        {
            if (ModelState.IsValid)
            {
                //Repository.AddResponse(guestResponse);
                return View("Thanks");
            }
            else
            {
                // there is a validation error
                return View();
            }
        }

        /*public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == 1));
        }*/


        public ViewResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }

        public ViewResult Legal()
        {
            return View();
        }
        [Authorize]
        public ViewResult Poll()
        {
            return View();
        }

        public ViewResult DLC()
        {
            return View();
        }

        public ViewResult Account()
        {
            return View();
        }
    }
}
