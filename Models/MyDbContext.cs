using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace pagamento_prova.Models
{
    public class MyDbContext: DbContext
    {
         public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }
        public DbSet<Consumidor> Consumidor{get;set;}
        public DbSet<Produto> Produto{get;set;}
        public DbSet<Pedido> Pedido{get;set;}
        public DbSet<Pagamento> Pagamento{get;set;}
        public DbSet<Boleto> Boleto{get;set;}
        public DbSet<Cartaodecredito> Cartaodecredito{get;set;}
    }
}