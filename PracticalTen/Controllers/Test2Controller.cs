using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticalTen.Controllers
{
	[HandleError]
	public class Test2Controller : Controller
    {
        // GET: Test2
        public ActionResult Index()
        {
            return View();
        }
		/// <summary>
		/// It is demo of JsonResult Method 
		/// </summary>
		/// <returns>It return Json Object</returns>
        [HttpGet]
		public JsonResult JsonTest()
		{
            var data = new { Name = "Vipul Kumar", ID = 153, DateOfBirth = new DateTime(1999, 07, 07) };
			return Json(data, JsonRequestBehavior.AllowGet);
		}

		[HttpGet]
		public JavaScriptResult WarningMessage()
		{
			var msg = "alert('Are you sure want to Continue?');";
			return new JavaScriptResult() { Script = msg };
		}

		public FileResult FileTest()
		{
			byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/App_Data/SimpleText.txt"));
			return File(fileBytes, "text/plain");
		}
		public ContentResult ContentTest()
		{
			return Content("<h3>This is a custom content</h3>", "text/html", System.Text.Encoding.UTF8);
		}
		public EmptyResult EmptyTest()
		{
			return new EmptyResult();
		}
		public PartialViewResult PartialViewTest()
		{
			return PartialView("_PartialViewTest");
		}
	}
}