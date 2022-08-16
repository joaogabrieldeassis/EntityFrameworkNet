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
                .HasMaxLength(150);
            
            builder.Property(x=>x.Email)

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
/*
 *      public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        public string Bio { get; set; }
*/