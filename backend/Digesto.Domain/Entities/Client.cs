using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digesto.Domain.Entities
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Document> Documents { get; set; }
    }
}
