using EfCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Data
{
    public  class BlogDataContext : DbContext
    {
        private readonly ILoggerFactory _logger = LoggerFactory.Create(x => x.AddConsole());
        public DbSet<Produto> Produtoos{ get; set; }
        public DbSet<Client> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options
                .UseLoggerFactory(_logger)
                .EnableSensitiveDataLogging()
                .UseSqlServer("Server=localhost,1433;Database=DensenvolvedorIo;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(BlogDataContext).Assembly);
           
        }
    }
}
