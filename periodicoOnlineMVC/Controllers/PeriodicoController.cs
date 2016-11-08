using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace periodicoOnlineMVC.Controllers
{
    public class PeriodicoController : Controller
    {
        // GET: Periodico
        public ActionResult Index()
        {
            return View();
        }
    }
}