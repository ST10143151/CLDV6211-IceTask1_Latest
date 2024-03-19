using Microsoft.AspNetCore.Mvc;

namespace MvcReminder.Controllers
{
    public class ReminderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
