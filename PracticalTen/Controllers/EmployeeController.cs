using System.Web.Mvc;

namespace PracticalTen.Controllers
{
	public class EmployeeController : Controller
	{
		[HandleError]
		[Route("Employee/{EmpName?}")]
		public ActionResult Index(string EmpName)
		{
			ViewBag.EmployeeName = EmpName;
			return View();
		}
	}
}