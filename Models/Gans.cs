using System;
using System.Collections.Generic;

namespace BPD01.Models
{
    public partial class Gans
    {
        public int Ganid { get; set; }
        public int GrantAdjustments { get; set; }
        public int Ganstatus { get; set; }
        public DateTime? SubmissionDate { get; set; }
        public string SubmissionInitials { get; set; }
        public string GanNotes { get; set; }
        public int FkGrantId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? AddWhen { get; set; }
        public string AddBy { get; set; }
        public DateTime? ModWhen { get; set; }
        public string ModBy { get; set; }

        public virtual Grants FkGrant { get; set; }
    }
}
