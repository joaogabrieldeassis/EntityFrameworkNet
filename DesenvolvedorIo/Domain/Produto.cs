using EfCore.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Domain
{
    public class Produto
    {
        public int Id { get; set; }
        public string CodigoDeBarras { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public TipoDoProduto TipoDoProduto { get; set; }
        public bool Ativo{ get; set; }
    }
}
