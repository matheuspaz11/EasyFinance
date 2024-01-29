using Microsoft.AspNetCore.Mvc;
using Platform.Entity;
using static Platform.Enum.Enum;

namespace EasyFinance.Controllers
{
    public class DespesasController : Controller
    {
        public IActionResult Index()
        {
            return View("Despesas");

        }

        public IActionResult CriarDespesa()
        {
            return View("CriarDespesa");
        }

        [HttpPost]
        public IActionResult SalvarDespesa(string descricao, decimal valor, TipoDespesa tipoDespesa, StatusDespesa statusDespesa)
        {
            Despesa despesa = new Despesa()
            {
                Descricao = descricao,
                Valor = valor,
                Tipo = tipoDespesa,
                Status = statusDespesa
            };

            return View("Despesas");
        }
    }
}


