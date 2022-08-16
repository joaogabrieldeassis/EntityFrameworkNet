using System.ComponentModel.DataAnnotations.Schema;

namespace blog.Models
{
    public class PostTag
    {
        public int PostId { get; set; }
        public int TagId { get; set; }
    }
}