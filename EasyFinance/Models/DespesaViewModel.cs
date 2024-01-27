using System.ComponentModel.DataAnnotations;

namespace EasyFinance.Models
{
    public class DespesaViewModel
    {
        [Required(ErrorMessage = "A descrição é obrigatória!")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória!")]
        [DataType(DataType.Currency)]
        public decimal Valor { get; set; }
    }
}
