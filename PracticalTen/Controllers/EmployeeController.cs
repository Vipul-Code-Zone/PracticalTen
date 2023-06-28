using System.Web.Mvc;

namespace PracticalTen.Controllers
{
	public class EmployeeController : Controller
	{
		public ActionResult Index(string EmpName)
		{
			ViewBag.EmployeeName = EmpName;
			return View();
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