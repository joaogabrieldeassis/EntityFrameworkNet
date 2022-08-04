using EfCore.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Domain
{
    public  class Client
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public Endereco Endereco{ get; set; }
    }
}
