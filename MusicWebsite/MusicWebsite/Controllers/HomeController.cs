using Microsoft.AspNetCore.Mvc;
using MusicWebsite.Models;
using System.Diagnostics;

namespace MusicWebsite.Controllers
{
    //[Route("")]
    [Route("home")]
    public class HomeController : Controller
    {

        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.username = HttpContext.Session.GetString("username");
            return View("index");
        }
       
       
    
}
}