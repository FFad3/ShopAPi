using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class OperationsInfo
    {
        public DateTime Created { get; set; }
        [MaxLength(30)]
        public string CreatedBy { get; set; }
        public DateTime? LastModified { get; set; }
        [MaxLength(30)]
        public string LastModifiedBy { get; set; }
    }
}
