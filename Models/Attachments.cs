using System;
using System.Collections.Generic;

namespace BPD01.Models
{
    public partial class Attachments
    {
        public Attachments()
        {
            Documents = new HashSet<Documents>();
        }

        public int Id { get; set; }
        public string FkTable { get; set; }
        public int FkId { get; set; }
        public string Uri { get; set; }
        public DateTime UploadDate { get; set; }
        public string Notes { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string AddBy { get; set; }
        public DateTime? AddWhen { get; set; }
        public string ModBy { get; set; }
        public DateTime? ModWhen { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Documents> Documents { get; set; }
    }
}
