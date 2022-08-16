using blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();
            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(160);

            builder.Property(x=>x.PasswordHash)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(255);

            builder.Property(x => x.Image)
                .IsRequired()
                .HasColumnType("NVARCHAR(max)");

            builder.Property(x => x.Slug)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Bio)
                .IsRequired()
                .HasColumnType("NVARCHAR(max)");

            //Abaixo temos um exemplo de mapeamento de objeto de valor

            /*builder.OwnsOne(x => x.Name, p =>
            {
                p.Property(x => x.FirstName)
                .IsRequired()
                .HasColumnType("NVARCHAR")
                .HasMaxLength(50);
                p.Property(x => x.LastName)
                .IsRequired()
                .HasColumnType("NVARVHAR")
                .HasMaxLength(100);
            }
            );
            */
        }
    }
}