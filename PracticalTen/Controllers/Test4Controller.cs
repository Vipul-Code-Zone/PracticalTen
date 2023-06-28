using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticalTen.Controllers
{
	public class Test4Controller : Controller
    {
        // GET: Test4
        [HandleError(ExceptionType = typeof(DivideByZeroException))]
        public ActionResult Index()
        {
            int x = 0;
            int y = 5/x;

            return View();
        }
    }
}