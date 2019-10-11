using System;
using System.Collections.Generic;

namespace BPD01.Models
{
    public partial class Reports
    {
        public int ReportId { get; set; }
        public DateTime ReportDate { get; set; }
        public string ReportType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string AddBy { get; set; }
        public string ModBy { get; set; }
        public int FkGrantId { get; set; }
        public bool IsDeleted { get; set; }
        public string FinancialReportingPeriod { get; set; }
        public string ProgrammingReportingPeriod { get; set; }
        public DateTime? DateSubmittedToGrantor { get; set; }

        public virtual Grants FkGrant { get; set; }
    }
}
