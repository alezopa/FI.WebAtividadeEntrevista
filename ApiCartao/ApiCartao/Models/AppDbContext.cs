using Microsoft.EntityFrameworkCore;

namespace ApiCartao.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        { }
        public DbSet<Pagamento> Pagamentos { get; set; }
    }
}
