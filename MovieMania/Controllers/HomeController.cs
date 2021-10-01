using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MovieMania.Models;
using MovieMania.Data;

namespace MovieMania.Controllers
{
    public class HomeController : Controller
    {

        private MovieManiaContext db = new MovieManiaContext();
        private string logedUser;
        private bool userFound = false;

        public ActionResult Index()
        {
            ViewBag.userId = User.Identity.GetUserName();
            logedUser = ViewBag.userId;

            //    if (logedUser != "") { 
            //        foreach (User u in db.Users)
            //        {
            //            if (logedUser == u.email)
            //            {
            //                userFound = true;
            //                break;
            //            }
            //        }
            //   }

            //   if (userFound || logedUser == "")
            //   {
            return View();
            //   }
            // /   else
            //   {
            //      return View("~/Views/Users/Create.cshtml");
            //  }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}