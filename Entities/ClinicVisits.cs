using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class ClinicVisits
    {
        public ClinicVisits()
        {
            Insemination = new HashSet<Insemination>();
            Iui = new HashSet<Iui>();
            Pct = new HashSet<Pct>();
            Sa = new HashSet<Sa>();
            SubsidizationNavigation = new HashSet<Subsidization>();
        }

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
        public bool?  Done { get; set; }
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
        public virtual Employees DoctorNavigation { get; set; }
        public virtual Persons Persons { get; set; }
        public virtual Employees PreformedNavigation { get; set; }
        public virtual Employees MorphologyNavigation { get; set; }
        public virtual Treatments Treatments { get; set; }
        //public  Employees DoctorNavigation { get; set; }
        //public  Persons Persons { get; set; }
        //public  Employees PreformedNavigation { get; set; }
        //public  Treatments Treatments { get; set; }
        public virtual ICollection<Insemination> Insemination { get; set; }
        public virtual ICollection<Iui> Iui { get; set; }
        public virtual ICollection<Pct> Pct { get; set; }
        public virtual ICollection<Sa> Sa { get; set; }
        public virtual ICollection<Subsidization> SubsidizationNavigation { get; set; }
    }
}
