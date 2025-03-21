using Microsoft.AspNetCore.Mvc;
using AIMSR_Website.Models;
using System.Linq;

namespace AIMSR_Website.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
    }
}
