using System;
using System.Collections.Generic;

namespace BPD01.Models
{
    public partial class Grants
    {
        public Grants()
        {
            Categories = new HashSet<Categories>();
            Comments = new HashSet<Comments>();
            Extensions = new HashSet<Extensions>();
            Gans = new HashSet<Gans>();
            Ldpr = new HashSet<Ldpr>();
            Reports = new HashSet<Reports>();
        }

        public bool? IsNew { get; set; }
        public string Division { get; set; }
        public string NickName { get; set; }
        public DateTime? FinancialReportDueDate { get; set; }
        public DateTime? ProgrammingReportDueDate { get; set; }
        public DateTime? ImportDate { get; set; }
        public decimal RemainingBal { get; set; }
        public int Id { get; set; }
        public string MshpGrantNumber { get; set; }
        public int Status { get; set; }
        public string GrantName { get; set; }
        public string CfdaNumber { get; set; }
        public string Component { get; set; }
        public string ProjectDirector { get; set; }
        public string Accountant { get; set; }
        public double? ApplicationAmount { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public DateTime? ExtendedProjectDate { get; set; }
        public decimal AwardAmount { get; set; }
        public decimal Expenditures { get; set; }
        public string AwardContractNumber { get; set; }
        public string Match { get; set; }
        public int Grantor { get; set; }
        public DateTime? ApplicationDueDate { get; set; }
        public int ApplicationStatus { get; set; }
        public int GrantCategory { get; set; }
        public int Forecast { get; set; }
        public string Adjustments { get; set; }
        public DateTime? AwardDate { get; set; }
        public int GrantType { get; set; }
        public bool IsDeleted { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModBy { get; set; }
        public DateTime? ModDate { get; set; }

        public virtual ICollection<Categories> Categories { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Extensions> Extensions { get; set; }
        public virtual ICollection<Gans> Gans { get; set; }
        public virtual ICollection<Ldpr> Ldpr { get; set; }
        public virtual ICollection<Reports> Reports { get; set; }
    }
}
