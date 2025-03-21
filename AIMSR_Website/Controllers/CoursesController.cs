using Microsoft.AspNetCore.Mvc;

namespace AIMSR_Website.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult MCA() { return View(); }
        public IActionResult MMS() { return View(); }
        public IActionResult BMS() { return View(); }
    }
}
