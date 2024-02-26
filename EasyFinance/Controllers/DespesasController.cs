using EasyFinance.Data;
using EasyFinance.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Platform.Enum.Enum;

namespace EasyFinance.Controllers
{
    public class DespesasController : Controller
    {
        private readonly EasyFinanceDbContext _conection;

        public DespesasController(EasyFinanceDbContext easyFinanceDbContext)
        {
            _conection = easyFinanceDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Despesas()
        {
            List<DespesaModel> despesaModels = _conection.Despesas.ToList();

            return View(despesaModels);
        }

        public IActionResult CriarDespesa()
        {
            return View("CriarDespesa");
        }

        [HttpPost]
        public IActionResult SalvarDespesa(string descricao, decimal valor, TipoDespesa tipoDespesa, StatusDespesa statusDespesa)
        {
            using var transaction = _conection.Database.BeginTransaction();

            try
            {
                DespesaModel despesaModel = new DespesaModel()
                {
                    Descricao = descricao,
                    Valor = valor,
                    Tipo = tipoDespesa,
                    Status = statusDespesa
                };
                _conection.Despesas.Add(despesaModel);

                _conection.SaveChanges();

                transaction.Commit();

                return RedirectToAction("Despesas");
            }
            catch (DbUpdateException)
            {
                transaction.Rollback();

                return RedirectToAction("Despesas");
            }
        }
    }
}