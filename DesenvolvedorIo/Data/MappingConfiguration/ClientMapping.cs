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
            builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();
            builder.Property(x => x.Name).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(x => x.Endereco).HasColumnType("CHAR(11)");
            builder.HasIndex("Name").HasName("Id_Cliente");
        }
    }
}
