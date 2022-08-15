using System.ComponentModel.DataAnnotations.Schema;

namespace blog.Models
{
    [Table("User")]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}