using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using PingPong.Models;

namespace PingPong.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet("/")]
		public ActionResult Index()
		{
			return View();
		}
		[HttpGet("/calculate")]
		public ActionResult Result()
		{
			PingPongClass newpingpong = new PingPongClass(int.Parse(Request.Query["number"]));
			return View("result", newpingpong.IsPingPong());
		}
	}
}