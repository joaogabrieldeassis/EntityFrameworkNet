using blog.Models;
using Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BucarUmUsuarioEspecifico();
        }
        //CRUD com performasse
        private static void BucarUmUsuarioEspecifico()
        {
            var blogDataContext = new BlogDataContext();
            var receiveAUser = blogDataContext.Users.AsNoTracking().ToList();
            foreach (var item in receiveAUser)
            {
                Console.WriteLine($"Id - {item.Id}");
            }
        }
    }
}
