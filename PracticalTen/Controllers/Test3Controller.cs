using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticalTen.Controllers
{
    public class Test3Controller : Controller
    {
        // GET: Test3
        [OutputCache(Duration = 300)]
        public ActionResult Index()
        {
            return View();
        }
    }
}