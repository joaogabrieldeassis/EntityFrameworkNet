using System.ComponentModel.DataAnnotations.Schema;

namespace blog.Models
{
    [Table("PostPostTag")]
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

    }
}