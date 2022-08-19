using blog.Models;
using Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AtualizandoDados();
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
                Roles = new List<Role>
                {
                   new Role
                   {
                       Name = "Role 1",
                       Slug = "João"
                   }
                }
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
            foreach (var item in receivePostAndUser)
            {
                Console.WriteLine($"IdPost - {item.Id}\nUser: {item.Author.Name}\n\n Roles: {item.Author.Roles}");
            }
        }
        
        private static void AtualizandoDados()
        {
            var blogDataContext = new BlogDataContext();

            var user = blogDataContext.Users.FirstOrDefault();
            user.Name = "João e Mary";
            blogDataContext.SaveChanges();
            // blogDataContext.Users.Update(user); //Esse formato ele executa duas querys no banco, 
            //Para resolvermos isso já chamamos o saveChanges que ele vai atualizar só com uma query
        }
    }
}
