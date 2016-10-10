using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConfigOptionsTest.Options;
using Microsoft.Extensions.Options;
using NamingTools;

namespace ConfigOptionsTest.Controllers
{
	public class HomeController : Controller
	{
		private readonly INamingService _namingService;

		public HomeController(INamingService namingService)
		{
			_namingService = namingService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			ViewData["Message"] = $"{_namingService.GetAppName()} description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Error()
		{
			return View();
		}
	}
}
