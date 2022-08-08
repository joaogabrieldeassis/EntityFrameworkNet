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
       
        public string Name { get; set; }
        public string Endereco { get; set; }
    }
}
