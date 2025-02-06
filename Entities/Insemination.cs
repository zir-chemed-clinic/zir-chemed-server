using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Insemination
    {
        public int InseminationId { get; set; }
        public int? ClinicVisitsId { get; set; }
        public string ManFathersName { get; set; }
        public string WomanFathersName { get; set; }
        public int? FolliclesNumber { get; set; }
        public bool? Signature1 { get; set; }
        public bool? Signature2 { get; set; }
        public bool? Signature3 { get; set; }
        public bool? DoctorSignature { get; set; }
        public int? DoctorLicenseNumber { get; set; }
        public string TreatmentDescription { get; set; }
        public string DoctorTreatment { get; set; }

        
        public bool? DoctorSignatureAfter { get; set; }
        public string TreatmentsTime { get; set; }
        public virtual ClinicVisits ClinicVisits { get; set; }
    }
}
