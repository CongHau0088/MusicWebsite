using Microsoft.AspNetCore.Mvc;
using MusicWebsite.Models;
using System.Diagnostics;

namespace MusicWebsite.Controllers
{
    [Route("/")]
    [Route("home")]
    public class HomeController : Controller
    {

        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View("index");
        }

     
    }
}