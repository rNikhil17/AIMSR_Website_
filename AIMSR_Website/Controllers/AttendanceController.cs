using Microsoft.AspNetCore.Mvc;

namespace AIMSR_Website.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
