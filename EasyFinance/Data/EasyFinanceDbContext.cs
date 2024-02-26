using EasyFinance.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyFinance.Data
{
    public class EasyFinanceDbContext : DbContext
    {
        public EasyFinanceDbContext(DbContextOptions<EasyFinanceDbContext> options): base(options)
        {}

        public DbSet<DespesaModel> Despesas {  get; set; }
    }
}
