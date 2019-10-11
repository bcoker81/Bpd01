using System;
using System.Collections.Generic;

namespace BPD01.Models
{
    public partial class Comments
    {
        public int CommentId { get; set; }
        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }
        public DateTime? ModWhen { get; set; }
        public string ModBy { get; set; }
        public string AddBy { get; set; }
        public int FkGrantId { get; set; }

        public virtual Grants FkGrant { get; set; }
    }
}
