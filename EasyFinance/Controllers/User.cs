using Microsoft.AspNetCore.Mvc;

namespace EasyFinance.Controllers
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            return View(User);
        }
    }
}
