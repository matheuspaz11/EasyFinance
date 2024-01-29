using System.ComponentModel.DataAnnotations;
using static Platform.Enum.Enum;

namespace EasyFinance.Models
{
    public class DespesaModel
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public TipoDespesa Tipo { get; set; }

        public StatusDespesa Status { get; set; }
    }
}
