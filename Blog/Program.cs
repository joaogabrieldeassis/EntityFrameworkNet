using blog.Models;
using Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConsultarDadodos();
        }
        public static void ConsultarDadodos()
        {
            var context = new BlogDataContext();
            var receiveToListInCategory = context.Users.AsNoTracking().Where(x => x.Id == 13).ToList();
            foreach (var item in receiveToListInCategory)
            {
                Console.WriteLine(item.Name);
            }

        }
        public static void CriarDados()
        {
            var context = new BlogDataContext();
            var user = new User
            {
                Name = "João Gabriel",
                Email = "joao@gmail.com",
                PasswordHash = "apoifjap9j",
                Image = "http>afaófk",
                Slug = "Muito bom "
            };
            context.Users.Add(user);
            context.SaveChanges();

        }
        public static void AtualizarDados()
        {
            /*var context = new BlogDataContext();
            var produtos = context.Produtoos.FirstOrDefault(x => x.Id == 1);
            produtos.Descricao = "Jesus eu te Amo muitaooo";
            //context.Produtoos.Update(produtos); //(Com o update ele irá tentar atualizar todos os campos da tabela, por isso é bom usar somente o savechances)
            context.SaveChanges();*/
            var context = new BlogDataContext();
            var user = context.Users.Find(33);
            user.Name = "João tem fé";
            user.Bio = "Olha";
            user.Slug = "slc";
            context.SaveChanges();
        }
        public static void ExcluirDados()
        {
            var context = new BlogDataContext();
            var user = new User { Id = 12 };
            context.Entry(user).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
