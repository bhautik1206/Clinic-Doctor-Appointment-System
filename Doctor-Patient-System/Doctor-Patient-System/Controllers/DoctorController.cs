using Microsoft.AspNetCore.Mvc;

namespace Doctor_Patient_System.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
