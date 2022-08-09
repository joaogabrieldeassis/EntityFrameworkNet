using EfCore.Data;
using EfCore.Domain;
using EfCore.ValueObjects;

namespace EfCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            InserindoDadosEmGrandeQuantidade();
        }
        private static void InserirDadosNoProduto()
        {
            var contextProduto = new BlogDataContext();
            /*
            var listaDeProdutos = new List<Produto>();
            listaDeProdutos.Add(new Produto("aifhja43","Muito Bom",500,ValueObjects.TipoDoProduto.Embalagem,true));
            contextProduto.Add(listaDeProdutos);
            var countSaveChanges = contextProduto.SaveChanges();
            */
            var produto = new Produto
            {
                CodigoDeBarras = "12334456576778",
                Descricao = "Muito bom",
                Valor = 200,
                TipoDoProduto = TipoDoProduto.Servico,
                Ativo = false
            };
            contextProduto.Produtoos.Add(produto);
            contextProduto.SaveChanges();
            

        }
        private static void InserindoDadosEmGrandeQuantidade()
        {
            var context = new BlogDataContext();
            var produto = new Produto();
            produto.CodigoDeBarras = "987654321";
            produto.Descricao = "Muito mas muito bom";
            produto.Valor = 200;
            produto.TipoDoProduto = TipoDoProduto.Embalagem;
            produto.Ativo = true;

            var cliente = new Client();
            cliente.Name = "João Gabriel de assis";
            cliente.Endereco = "Rua eusebio";
            context.AddRange(produto,cliente);
            var receiveSaveChabges = context.SaveChanges();
            Console.WriteLine($"Esse é o número de registros inseridos: {receiveSaveChabges}");
        }
        

    }
}
