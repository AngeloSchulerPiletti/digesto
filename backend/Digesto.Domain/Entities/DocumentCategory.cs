using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digesto.Domain.Entities
{
    public class DocumentCategory : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
