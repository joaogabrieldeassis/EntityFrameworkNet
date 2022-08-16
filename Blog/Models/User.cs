using Blog.Models.ValueObjects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace blog.Models
{
    public class User
    {
        public int Id { get; set; }
        public FirstNameLatName Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        public string Bio { get; set; }
    }
}