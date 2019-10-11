using System;
using System.Collections.Generic;

namespace BPD01.Models
{
    public partial class Extensions
    {
        public int GrantExtensionId { get; set; }
        public DateTime ExtensionDate { get; set; }
        public DateTime? ModWhen { get; set; }
        public DateTime? AddWhen { get; set; }
        public string ModBy { get; set; }
        public string AddBy { get; set; }
        public int FkGrantId { get; set; }

        public virtual Grants FkGrant { get; set; }
    }
}
