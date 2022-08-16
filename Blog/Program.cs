using blog.Models;
using Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ListandoPostEmMassa();
        }
        public static void ConsultarDadodos()
        {
            var context = new BlogDataContext();
            var receiveUsers = context.Users.AsNoTracking().ToList();
            foreach (var item in receiveUsers)
            {
                Console.WriteLine($"Id - {item.Id}\nName - {item.Name}");
            }
        }
        public static void CriarDados()
        {
            var context = new BlogDataContext();
            var user = new User
            {
                Name = "João Gabriel 030",
                Email = "joaomary@gmail.com"
            };
        }
        public static void AtualizarDados()
        {
            var context = new BlogDataContext();
            var userUpdate = context.Users.Find(13);
            userUpdate.Name = "João gatão";
            //context.Update(userUpdate); Evitar de usar o update por que ele dá dois riti no banco
            context.SaveChanges();
        }
        public static void ExcluirDados()
        {
            var context = new BlogDataContext();
            var user = new User { Id = 13 };
            context.Entry(user).State = EntityState.Deleted;
            context.SaveChanges();
        }
        private static void ListandoPostEmMassa()
        {
            var context = new BlogDataContext();
            var receiveListUser = context.Posts.AsNoTracking().Include(x => x.CategoryId);
            foreach (var item in receiveListUser)
            {
                Console.WriteLine($"Title Post - {item.Title}\nName Category - {item.CategoryId}");
            }
        }
    }
}
