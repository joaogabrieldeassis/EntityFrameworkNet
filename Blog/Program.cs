using blog.Models;
using Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            InserindoDadosComPerformasse();
        }
        //CRUD com performasse
        private static void InserindoDadosComPerformasse()
        {
            var context = new BlogDataContext();
            var category = new Category
            {
                Name = "João Category",
                Slug = "Muito bom"
            };

            var user = new User
            {
                Name = "João Gabriel",
                Email = "joao@gmail",
                PasswordHash = "aopfjap09OF",
                Image = "http: João lindo",
                Slug = "Aaaaaaaa",
                Bio = "Curso Muito bom",
            };
            var post = new Post
            {
                Category = category,
                Author = user,
                Title = "Primeiro Titulo",
                Sumary = "Sumario",
                Body = "João",
                Slug = "Muito bom",
                CreateDateTime = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                
            };
            context.Posts.Add(post);
            context.SaveChanges();
        }
        private static void ConsultandoDadosDadosDeTresTabelasDiferentes()
        {
            var context = new BlogDataContext();
            var receivePostAndUser = context.Posts.AsNoTracking().Include(x => x.Author).ThenInclude(x=>x.Roles).ToList();
        }
        /*
         public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        public string Bio { get; set; }
        public IList<Post> Posts { get; set; }
        public IList<Role> Roles { get; set; }*/
        private static void BucarUmUsuarioEspecifico()
        {
            var blogDataContext = new BlogDataContext();
            var receiveAUser = blogDataContext.Users.AsNoTracking().Where(x => x.Id == 33).ToList();
            foreach (var item in receiveAUser)
            {
                Console.WriteLine($"Id - {item.Id}");
            }
        }
    }
}
