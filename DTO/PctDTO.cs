using System;
using System.Collections.Generic;

namespace DTO
{
    public partial class PctDTO
    {
        public int Pctid { get; set; }
        public int? ClinicVisitsId { get; set; }
        public string MensesDay { get; set; }
        public string HoursPost { get; set; }
        public string TotalSpermsHpf { get; set; }
        public string GoodMotileSperm { get; set; }
        public string Elasticity { get; set; }
        public string Clarity { get; set; }
        public string Amount { get; set; }
        public string Cellularity { get; set; }
        public string Fernig { get; set; }
        public string Comments { get; set; }
        public string DoctorTreatment { get; set; }

    }
}
