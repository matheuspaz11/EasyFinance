using Microsoft.AspNetCore.Mvc;

namespace EasyFinance.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }
    }
}
