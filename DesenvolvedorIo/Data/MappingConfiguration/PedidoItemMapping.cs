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
    public class PedidoItemMapping : IEntityTypeConfiguration<PedidoItem>

    {
        public void Configure(EntityTypeBuilder<PedidoItem> builder)
        {
            builder.ToTable("PedidoItem");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantidade).HasDefaultValue(1).IsRequired();
            builder.Property(x => x.Valor).HasDefaultValue(1).IsRequired();
            builder.Property(x => x.Desconto).HasDefaultValue(1).IsRequired();
        }
    }
}
/*
 public int Id { get; set; }
        public int PedidoId{ get; set; }
        public Pedido Pedido { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Valor{ get; set; }
        public double MyProperty { get; set; }
 */