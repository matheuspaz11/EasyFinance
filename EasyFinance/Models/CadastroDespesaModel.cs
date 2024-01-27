using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EasyFinance.Models
{
    public class CadastroDespesaModel: PageModel
    {
        public DespesaViewModel Despesa {  get; set; }

        public void OnGet()
        {
            Despesa = new DespesaViewModel();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                return RedirectToPage("Despesas");
            }

            return Page();
        }
    }
}
