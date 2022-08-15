using System.ComponentModel.DataAnnotations.Schema;

namespace blog.Models
{
    [Table("PostPostTag")]
    public class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
    }
}