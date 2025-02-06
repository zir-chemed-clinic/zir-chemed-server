using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Treatments
    {
        public Treatments()
        {
            ClinicVisits = new HashSet<ClinicVisits>();
        }

        public int TreatmentId { get; set; }
        public string TreatmentName { get; set; }
        public int? TreatmentCost { get; set; }

        public virtual ICollection<ClinicVisits> ClinicVisits { get; set; }
    }
}
