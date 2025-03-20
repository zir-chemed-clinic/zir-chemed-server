using System;
using System.Collections.Generic;

namespace DTO
{
    public partial class SaDTO
    {
        public int Said { get; set; }
        public int? ClinicVisitsId { get; set; }
        public string DoctorTreatment { get; set; }
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
        public string Ph { get; set; }
        public string Comments { get; set; }
        public string NormalForms { get; set; }
        public string LargeHeads { get; set; }
        public string SmallHeads { get; set; }
        public string RoundHeads { get; set; }
        public string TaperedHeads { get; set; }
        public string PyramidalHeads { get; set; }
        public string AmorphousHeads { get; set; }
        public string PinHeads { get; set; }
        public string NeckDefects { get; set; }
        public string CytoplasmicDroplets { get; set; }
        public string TailDefects { get; set; }
        public string GivingSample { get; set; }

        public string DaysAvoided { get; set; }
        public string Signature { get; set; }

    }
}
