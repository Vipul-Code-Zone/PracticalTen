using System.Web.Mvc;

namespace PracticalTen.Controllers
{
	//[HandleError(ExceptionType =typeof(System.Exception), View = "~/Error/PageNotFoundError")]
	public class EmployeeController : Controller
	{
		[HandleError]
		public ActionResult Index(string EmpName)
		{
			ViewBag.EmployeeName = EmpName;
			return View();
		}
	}
}