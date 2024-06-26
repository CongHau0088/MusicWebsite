﻿using Microsoft.AspNetCore.Mvc;

namespace MusicWebsite.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/dashboard")]
    public class DashboardController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View("index");
        }
    }
}
