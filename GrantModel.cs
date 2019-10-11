namespace bpd01 {
    public enum GrantStatus {
        Opened,
        Closed,
        Pending,
        Denied
    }

    public class GrantModel {
        public int GrantId { get; set; }
        public string GrantNumber { get; set; }
        public string GrantName { get; set; }
        public GrantStatus Status { get; set; }
        public string Division { get; set; }
    }
}