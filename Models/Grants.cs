using System;
using System.Collections.Generic;

namespace BPD01.Models
{
    public partial class Grants
    {
        public int Id { get; set; }
        public int GrantNumber { get; set; }
        public string GrantName { get; set; }
        public string Status { get; set; }
        public string Division { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public DateTime? FinancialReportDueDate { get; set; }
        public DateTime? ProgrammingReportDueDate { get; set; }
        public int? AwardAmount { get; set; }
        public int? Expenditures { get; set; }
        public int? RemainingBalance { get; set; }
        public int? PercentOfFundsSpent { get; set; }
        public int? Match { get; set; }
    }
}
