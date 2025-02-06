using System;
using System.Collections.Generic;

namespace DTO
{
    public partial class ClinicVisitsDTO
    {

        public int ClinicVisitsId { get; set; }
        public int? TreatmentsId { get; set; }
        public int? PersonsId { get; set; }
        public int? Preformed { get; set; }
        public int? Doctor { get; set; }
        public int? Morphology { get; set; }
        public string PaymentMethod { get; set; }
        public int? Receipt { get; set; }
        public bool? C { get; set; }
        public bool? Co { get; set; }
        public int? Amount { get; set; }
        public int? Status { get; set; }

        public bool? Subsidization { get; set; }
        public bool? Closed { get; set; }
        public bool? ClosedSA { get; set; }
        public bool? ClosedIUI { get; set; }
        public bool? Done { get; set; }
        public bool? DoneDoctor { get; set; }
        public bool? DoneMorphology { get; set; }
        public bool? DidNotArrive { get; set; }
        public bool? ApartmentHr { get; set; }
        public bool? ApartmentVy { get; set; }
        public bool? ApartmentYy { get; set; }
        public DateTime? VisitsDate { get; set; }
        public string? VisitTime { get; set; }
        public bool? SubsidizationApprove { get; set; }
        public string SubsidizationAmount { get; set; }
        public string CheckNumber { get; set; }
        public  EmployeesDTO DoctorNavigation { get; set; }
        public  PersonsDTO Persons { get; set; }
        public  EmployeesDTO PreformedNavigation { get; set; }
        public  EmployeesDTO MorphologyNavigation { get; set; }
        public  TreatmentsDTO Treatments { get; set; }

    }
}
