using System;
using System.Collections.Generic;

namespace BPD01.Models
{
    public partial class Expenditures
    {
        public int ExpenditureId { get; set; }
        public DateTime? ExpenditureDate { get; set; }
        public string DocumentNumber { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public string Notes { get; set; }
        public bool? DivStatus { get; set; }
        public DateTime? BpdDate { get; set; }
        public decimal BpdAmount { get; set; }
        public string SamDocNumber { get; set; }
        public string Vendor { get; set; }
        public string BpdNotes { get; set; }
        public string AddBy { get; set; }
        public DateTime? AddWhen { get; set; }
        public string ModBy { get; set; }
        public DateTime? ModWhen { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsCredit { get; set; }
        public int FkCategoryId { get; set; }

        public virtual Categories FkCategory { get; set; }
    }
}
