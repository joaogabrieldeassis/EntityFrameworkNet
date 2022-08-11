using EfCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Data.MappingConfiguration
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
            builder.Property(x => x.IniciandoEm).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(x => x.FinalizandoEm).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
            builder.Property(x => x.TipoDeFrete).HasConversion<int>();
            builder.Property(x => x.Status).HasConversion<string>();
            builder.Property(x => x.Observacao).HasColumnType("NVARCHAR(200)");

            builder.HasMany(x=>x.PedidoItems)
                .WithOne(x=>x.Pedido)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
/*
 *  public int Id { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public DateTime IniciandoEm { get; set; }
        public DateTime FinalizandoEm{ get; set; }
        public TipoDeFrete TipoDeFrete{ get; set; }
        public StatusDoPedido Status{ get; set; }
        public string Observacao{ get; set; }
 * */