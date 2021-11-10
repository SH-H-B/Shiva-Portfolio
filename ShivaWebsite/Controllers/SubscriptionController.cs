using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShivaWebsite.Models;

namespace ShivaWebsite.Controllers
{
    // name of my controller is Subscription
    public class SubscriptionController : Controller
    {
        // GET: Subscription (IGNORE)
        public ActionResult Index()
        {
            return View();
        }
        // This function return json result.
        public JsonResult getALLEmails()
        {
            Subscription subscribtioModeln = new Subscription();
            return Json(subscribtioModeln.getAllEmails(), JsonRequestBehavior.AllowGet);

        }

        public JsonResult addSubscription(string userEmail)
        {
            ////To check if it is Null or empty
            if (string.IsNullOrEmpty(userEmail))
            {
                return Json("email is mandotory");
            }
            Subscription subscribtioModeln = new Subscription();
            return Json(subscribtioModeln.addSubscription(userEmail));
        }

    }
}