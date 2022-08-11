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
            AtualizandoDadosComPerfomasse();
        }
        private static void AtualizandoDadosComPerfomasse()
        {
            var context = new BlogDataContext();
            var user = context.Clientes.FirstOrDefault(x => x.Id == 1);
            user.Name = "João Gabriel lindao";
            //context.Clientes.Update(user); (Com o update ele irá tentar atualizar todos os campos da tabela, por isso é bom usar somente o savechances)
            context.SaveChanges();
            
        }
        private static void InserindoDadosNoClienteEsuasTabelasDeRelacao()
        {
            var dataContext = new BlogDataContext();
            var dadosCliente = dataContext.Clientes.FirstOrDefault();
            var dadosProdutos = dataContext.Produtoos.FirstOrDefault();
           
            var pedido = new Pedido
            {
                ClienteID = dadosCliente.Id,
                IniciandoEm = DateTime.Now,
                FinalizandoEm = DateTime.Now,
                Observacao = "João é fiho de Deus",
                Status = StatusDoPedido.Analise,
                TipoDeFrete = TipoDeFrete.SemFrete,
                PedidoItems = new List<PedidoItem>()
                {
                    new PedidoItem
                    {
                        ProdutoId = dadosProdutos.Id,
                        Desconto = 0,
                        Quantidade = 0,
                        Valor = 20
                    }
                }
            };
            dataContext.Pedidos.Add(pedido);
            dataContext.SaveChanges();
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

            //var cliente = new Client(0,"João Gabriel de assis", "Rua eusebio");
            //context.AddRange(produto,cliente);
            var receiveSaveChabges = context.SaveChanges();
            Console.WriteLine($"Esse é o número de registros inseridos: {receiveSaveChabges}");
        }
        private static void ConsultandoDados()
        {
            var context = new BlogDataContext();
            //var receiveListUser = context.Clientes.AsNoTracking().Where(x=>x.Name == "joao").ToList();
            var receivelListProduto = context.Pedidos.Include(x=>x.PedidoItems).ThenInclude(x=>x.Quantidade);
            foreach (var item in receivelListProduto)
            {
               
                Console.WriteLine(item.Id);
                Console.WriteLine(item.IniciandoEm);
                Console.WriteLine(item.Observacao);
                Console.WriteLine(item.ClienteID);
            }
        }
        private static void InsercaoDeDadosViaCliente()
        {
            var listClient = new List<Client>();
            var context = new BlogDataContext();
            Console.WriteLine("Digite o seu nome");
            var receiveClient = Console.ReadLine();
            var receiveClientEndereço = Console.ReadLine();
            //listClient.Add(new Client(receiveClient,receiveClientEndereço));  
        }
    }
}
