using blog.Models;
using Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var context = new BlogDataContext();
            ConsultandoDadosDadosDeTresTabelasDiferentes(context);
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
        private static async Task<List<User>> ConsultandoDadosDadosDeTresTabelasDiferentes(BlogDataContext context)
        {
            return await context.Users.ToListAsync();
            Console.WriteLine();
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
