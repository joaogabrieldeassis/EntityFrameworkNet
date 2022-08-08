using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Domain
{
    public class BaseId
    {
        public BaseId()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
