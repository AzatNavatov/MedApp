using Microsoft.AspNetCore.Mvc;

namespace MedApp.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
