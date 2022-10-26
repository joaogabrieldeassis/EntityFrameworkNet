using EfCore.Data;
using EfCore.Domain;
using EfCore.ValueObjects;
using Microsoft.EntityFrameworkCore;

namespace EfCore
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsultandoDados();
        }
        private static void AtualizandoDadosComPerfomasse(BlogDataContext context)
        {

        }
        private static void InserindoDadosNoClienteEsuasTabelasDeRelacao(BlogDataContext context)
        {

        }
        private static void InserirDadosNoProduto(BlogDataContext context)
        {
            var produtos = new Produto
            {
                CodigoDeBarras = "230943092340",
                Descricao = "Produto de qualidade",
                Valor = 90.99,
                TipoDoProduto = TipoDoProduto.Servico,
                Ativo = true
            };
            context.Produtoos.Add(produtos);
            context.SaveChanges();
        }
        private static void InserindoDadosEmGrandeQuantidade()
        {

        }
        private static void ConsultandoDados()
        {
            var context = new BlogDataContext();
            var receiveProdutos = context.Produtoos.AsNoTracking().ToList();
            foreach (var item in receiveProdutos)
            {
                Console.WriteLine($"Id {item.Id} Valor {item.Valor}");
            }
        }
        private static void InsercaoDeDadosViaCliente()
        {

        }
        private static void ExclusaoDeDadosComperformasse()
        {

        }
    }
}
