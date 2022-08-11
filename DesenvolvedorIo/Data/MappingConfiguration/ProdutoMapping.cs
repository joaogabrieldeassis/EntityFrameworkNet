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
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
            builder.Property(x => x.CodigoDeBarras).HasColumnType("NVARCHAR(150)").IsRequired();
            builder.Property(x => x.Descricao).HasColumnType("NVARCHAR(300)").IsRequired();
            builder.Property(x => x.Valor).IsRequired();
            builder.Property(x => x.TipoDoProduto).HasConversion<string>();
        }
    }
}
/*
 * public int Id { get; set; }
        public string CodigoDeBarras { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public TipoDoProduto TipoDoProduto { get; set; }
        public bool Ativo{ get; set; }
 */