using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaskSystem;

namespace WebApplication1.Controllers
{
	public class HomeController : Controller
	{
		private ITaskSystem system = new TaskSystem.TaskSystem();

		public ActionResult Index()
		{
			if (system.VerifyUser("demo", ""))
			{
				ViewBag.Logged = "YeahBitch!";
			}
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