using Microsoft.AspNetCore.Mvc;

namespace MusicWebsite.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
