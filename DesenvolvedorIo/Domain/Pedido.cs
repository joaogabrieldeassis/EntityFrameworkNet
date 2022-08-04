using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Domain
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public DateTime IniciandoEm { get; set; }
        public DateTime FinalizandoEm{ get; set; }
        public TipoDeFrete TipoDeFrete{ get; set; }
        public Status Status{ get; set; }
        public string Observacao{ get; set; }

        public List<PedidoItem>{ get; set; }
    }
}
