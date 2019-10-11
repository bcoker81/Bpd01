using System;
using System.Collections.Generic;

namespace BPD01.Models
{
    public partial class PickLists
    {
        public int PickListId { get; set; }
        public int Index { get; set; }
        public string PickList { get; set; }
        public string Value { get; set; }
        public bool IsDeleted { get; set; }
        public string AddBy { get; set; }
        public DateTime AddWhen { get; set; }
        public string ModBy { get; set; }
        public DateTime? ModWhen { get; set; }
    }
}
