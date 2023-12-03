using CodeFirstMVC.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        LockContext db = new LockContext();
        public ActionResult Index()
        {
            return View(db.Locks.ToList());
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