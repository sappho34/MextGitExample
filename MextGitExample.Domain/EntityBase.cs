using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MextGitExample.Domain
{
    public class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }
}