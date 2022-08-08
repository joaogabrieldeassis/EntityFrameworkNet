using EfCore.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Domain
{
    public  class Client : BaseId
    {
        public Client(string name, Endereco endereco)
        {
            Name = name;
            Endereco = endereco;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Endereco Endereco{ get; set; }
    }
}
