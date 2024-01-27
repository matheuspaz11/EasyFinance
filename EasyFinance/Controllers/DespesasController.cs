using Microsoft.AspNetCore.Mvc;

namespace EasyFinance.Controllers
{
    public class DespesasController : Controller
    {
        public IActionResult Index()
        {
            return View("Despesas");
        }
    }
}
