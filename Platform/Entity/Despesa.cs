using static Platform.Enum.Enum;

namespace Platform.Entity
{
    public class Despesa
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public TipoDespesa Tipo { get; set; }

        public StatusDespesa Status { get; set; }
    }
}
