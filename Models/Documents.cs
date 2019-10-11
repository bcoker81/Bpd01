using System;
using System.Collections.Generic;

namespace BPD01.Models
{
    public partial class Documents
    {
        public int DocumentId { get; set; }
        public string DocumentData { get; set; }
        public DateTime AddedDate { get; set; }
        public int FkAttachmentId { get; set; }

        public virtual Attachments FkAttachment { get; set; }
    }
}
