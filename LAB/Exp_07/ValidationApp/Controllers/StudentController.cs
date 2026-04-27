using Microsoft.AspNetCore.Mvc;
using ValidationApp.Models;

namespace ValidationApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Message="Form Submitted Successfully";
            }

            return View(student);
        }
    }
}