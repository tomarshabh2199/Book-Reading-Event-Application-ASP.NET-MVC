using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookReadingEvent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyEvents()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult EventsInvited()
        {
            ViewBag.Message = "Events in which you are invited";

            return View();
        }

        public ActionResult CreateEvent()
        {
            ViewBag.message = "you can create your own events";

            return View();
        }

        public ActionResult Login()//which view is going to be return
        {
            ViewBag.message = "";

            return View();
        }

       
        public ViewResult Admin()//which view is going to be return
        {
            ViewData["error"] = "Admin Credentials are Correct";
            ViewBag.message = "";

            return View();
        }

        public ViewResult Blank()//which view is going to be return
        {
            ViewBag.message = "";

            return View();
        }

        public ActionResult BookReadingEventPage()//which view is going to be return
        {
            ViewBag.message = "";

            return View();
        }

        public ActionResult PastEvents()//which view is going to be return
        {
            ViewBag.message = "These are the all past events";

            return View();
        }

        public ActionResult FutureEvents(){ // which view is going to be return        {
            ViewBag.message = "These are the that are occuring in the future";

            return View();
        }

        //Future Event
        public ActionResult GotoEvent()
        {
            return View();
        }

        public ActionResult EventLink()
        {
            return View();

        }

        public ActionResult EventEdit()
        {
            return View();
        }

        public ActionResult RDSharmaEventEdit()
        {
            return View();
        }

        public ActionResult ThermodynamicsEventEdit()
        {
            return View();
        }
  
        public ActionResult CryptocurrencyEventEdit()
        {
            return View();
        }

        public ActionResult AttackEventEdit()
        {
            return View();
        }

        //Past Event
        public ActionResult HarryPotterEventEdit()
        {
            return View();
        }

        public ActionResult MarvelSeriesEventEdit()
        {
            return View();
        }

        public ActionResult KotaSeriesEventEdit()
        {
            return View();
        }

        public ActionResult AvengerEventEdit()
        {
            return View();
        }

        public ActionResult DoremonEventEdit()
        {
            return View();
        }

        //EventLink
        public ActionResult DoremonEventLink()
        {
            return View();
        }

    }
}