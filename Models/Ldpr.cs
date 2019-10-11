using System;
using System.Collections.Generic;

namespace BPD01.Models
{
    public partial class Ldpr
    {
        public int LdprId { get; set; }
        public string LdprNumber { get; set; }
        public int FkGrantId { get; set; }
        public DateTime? AddWhen { get; set; }
        public DateTime? ModWhen { get; set; }
        public string AddBy { get; set; }
        public string ModBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Grants FkGrant { get; set; }
    }
}
