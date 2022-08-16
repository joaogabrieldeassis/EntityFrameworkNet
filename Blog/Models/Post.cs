using System.ComponentModel.DataAnnotations.Schema;

namespace blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Sumary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public Category Category { get; set; }
        public User Author { get; set; }
        public IList<Tag> Tags { get; set; }
    }
}