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
    public class ClientMapping : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(150);
            builder.OwnsOne(x => x.Endereco,endereco=>
            {
                endereco.Property(x => x.Cep)
                .HasColumnName("Cep")
                .HasColumnType("NVARCHAR(14)")
                .IsRequired();

                endereco.Property(x => x.Cidade)
                .HasColumnName("Cidade")
                .HasColumnType("NVARCHAR(100)")
                .IsRequired();

                endereco.Property(x => x.Estado)
                .HasColumnName("Estado")
                .HasColumnType("NVARCHAR(50)")
                .IsRequired();
            });
            builder.HasIndex("Name").HasName("Id_Cliente");
        }
    }
}
