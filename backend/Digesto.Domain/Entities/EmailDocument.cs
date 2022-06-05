using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digesto.Domain.Entities
{
    public class EmailDocument : BaseEntity
    {
        public string Url { get; set; }
        public uint? InsuranceTypeId { get; set; }
        public virtual InsuranceType InsuranceType { get; set; }
        public uint EmailId { get; set; }
        public virtual Email Email { get; set; }
    }
}
