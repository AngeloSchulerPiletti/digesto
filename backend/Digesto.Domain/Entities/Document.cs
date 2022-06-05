using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digesto.Domain.Entities
{
    public class Document : BaseEntity
    {
        public string Url { get; set; }
        public int ClientId { get; set; }
        public int? DocumentCategoryId { get; set; }
        public virtual DocumentCategory DocumentCategory { get; set; }
        public virtual Client Client { get; set; }
    }
}
