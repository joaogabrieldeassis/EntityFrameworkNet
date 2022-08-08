using EfCore.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Domain
{
    public class Pedido : BaseId
    {

        public int ClienteID { get; set; }
        public Client Client { get; set; }
        public DateTime IniciandoEm { get; set; }
        public DateTime FinalizandoEm{ get; set; }
        public TipoDeFrete TipoDeFrete{ get; set; }
        public StatusDoPedido Status{ get; set; }
        public string Observacao{ get; set; }

        public List<PedidoItem> PedidoItems{ get; set; }
    //Um pedido tem muitos itens De Pedido
    }
}
