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
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.Desconto).IsRequired();
        }
    }
}
