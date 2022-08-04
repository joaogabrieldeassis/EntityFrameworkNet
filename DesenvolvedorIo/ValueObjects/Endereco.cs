using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.ValueObjects
{
    public class Endereco
    {
        public int Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado{ get; set; }
    }
}
