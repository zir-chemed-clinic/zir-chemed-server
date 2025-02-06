using System;
using System.Collections.Generic;

namespace DTO
{
    public partial class SubsidizationDTO
    {
        public int SubsidizationId { get; set; }
        public int? ClinicVisitsId { get; set; }
        public DateTime? DatePlease { get; set; }
        public string ManWork { get; set; }
        public string WomanWork { get; set; }
        public string RabbiName { get; set; }
        public string RabbiPhone { get; set; }
        public string Comments { get; set; }
        public bool? RequestReceived { get; set; }
        public string CheckedBy { get; set; }
        public int? Amount { get; set; }
        public string CommentsOffice { get; set; }
        public int? CheckNumber { get; set; }

    }
}
