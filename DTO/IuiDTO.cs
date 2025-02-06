using System;
using System.Collections.Generic;

namespace DTO
{
    public partial class IuiDTO
    {
        public int Iuiid { get; set; }
        public int? ClinicVisitsId { get; set; }
        public bool? Fresh { get; set; }
        public bool? Condom { get; set; }
        public bool? Ejac { get; set; }
        public bool? Cup { get; set; }
        public string Other { get; set; }
        public DateTime? GivingTime { get; set; }
        public string GivingTimeString { get; set; }
        public string VolumeCc { get; set; }
        public string Appearance { get; set; }
        public string Conc105cc { get; set; }
        public string Motility { get; set; }
        public string Motility_rank_1 { get; set; }

        public string Motility_rank_2 { get; set; }
        public string Motility_rank_3 { get; set; }
        public string Motility_rank_4 { get; set; }
        public string Grade { get; set; }
        public string PH { get; set; }
        public string Comments { get; set; }
        public bool? WimUp { get; set; }
        public bool? Gradient { get; set; }
        public bool? Wash { get; set; }
        public bool? OtherTreatment { get; set; }
        public string CommentsTreatment { get; set; }

        public string VolumeCcAfterTreatment { get; set; }
        public string Conc105ccAfterTreatment { get; set; }
        public string MotilityAfterTreatment { get; set; }
        public string MotilityAfterTreatment_1 { get; set; }

        public string MotilityAfterTreatment_2 { get; set; }
        public string MotilityAfterTreatment_3 { get; set; }
        public string MotilityAfterTreatment_4 { get; set; }
        public string GradeAfterTreatment { get; set; }
        public string PHAfterTreatment { get; set; }
        public string TotalMotileCount { get; set; }
        public string EmailForSendingResults { get; set; }
        public string DoctorTreatment { get; set; }
        public string FolliclesNumber { get; set; }

    }
}
