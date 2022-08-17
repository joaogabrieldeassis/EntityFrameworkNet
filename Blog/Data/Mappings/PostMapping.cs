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
    public class PostMapping : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Post");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Title)
               .IsRequired()
               .HasColumnType("NVARCHAR(max)");

            builder.Property(x => x.Sumary)
                .IsRequired()
                .HasColumnType("NVARCHAR(max)");

            builder.Property(x=>x.Body)
                .IsRequired()
                .HasColumnType("NVARCHAR(max)");

            builder.Property(x => x.Slug)
                .IsRequired()
                .HasColumnType("NVARCHAR(max)");

            builder.Property(x => x.CreateDateTime)
                .IsRequired()
                .HasColumnType("SMALLDATETIME")
                .HasDefaultValue(DateTime.Now.ToUniversalTime());
                ;
        }
    }
}
/*
 public int Id { get; set; }
        public string Title { get; set; }
        public string Sumary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int UserId { get; set; }
        public User Author { get; set; }
        public IList<Tag> Tags { get; set; }
 */