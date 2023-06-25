using Microsoft.AspNetCore.Mvc;

namespace Fiorello.Controllers
{
	public class BlogsController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Details() 
		{
			return View();
		}
	}
}
