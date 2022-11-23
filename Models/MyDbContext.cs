using Microsoft.EntityFrameworkCore;

namespace pagamento.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {
        
        }
        public DbSet<Consumidor> Consumidor{get;set;}
        public DbSet<Produto> Produto{get;set;}
        public DbSet<Pagamento> Pagamento{get;set;}
        public DbSet<Boleto> Boleto{get;set;}
        public DbSet<Cartaodecredito> Cartaodecredito{get;set;}
    }
}