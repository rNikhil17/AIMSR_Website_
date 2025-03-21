using Microsoft.AspNetCore.Mvc;

namespace AIMSR_Website.Controllers
{
    public class ResultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
