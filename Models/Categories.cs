using System;
using System.Collections.Generic;

namespace BPD01.Models
{
    public partial class Categories
    {
        public Categories()
        {
            Expenditures = new HashSet<Expenditures>();
        }

        public int CatId { get; set; }
        public int Agency { get; set; }
        public string ReportingCategory { get; set; }
        public int CategoryClassification { get; set; }
        public string Description { get; set; }
        public decimal? Allocation { get; set; }
        public decimal? Expenses { get; set; }
        public decimal? Remaining { get; set; }
        public string Notes { get; set; }
        public string AddBy { get; set; }
        public DateTime? AddWhen { get; set; }
        public string ModBy { get; set; }
        public int Division { get; set; }
        public DateTime? ModWhen { get; set; }
        public bool IsDeleted { get; set; }
        public int FkGrantId { get; set; }

        public virtual Grants FkGrant { get; set; }
        public virtual ICollection<Expenditures> Expenditures { get; set; }
    }
}
