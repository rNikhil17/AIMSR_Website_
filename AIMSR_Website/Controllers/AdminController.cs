using Microsoft.AspNetCore.Mvc;

namespace AIMSR_Website.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
