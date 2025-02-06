using System;
using System.Collections.Generic;

namespace Entities
{
    public partial class Employees
    {
        public Employees()
        {
            ClinicVisitsDoctorNavigation = new HashSet<ClinicVisits>();
            ClinicVisitsPreformedNavigation = new HashSet<ClinicVisits>();
            ClinicVisitsMorphologyNavigation = new HashSet<ClinicVisits>();
        }

        public int EmployeeId { get; set; }
        public int? EmployeeIdNumber { get; set; }
        public int? Role { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeePhone { get; set; }
        public int? EmployeePermission { get; set; }
        public string Degree { get; set; }
        public string EmployeEemail { get; set; }
        public string EmployeePassword { get; set; }
        public int? DoctorLicenseNumber { get; set; }
        public int? LicenseNumber { get; set; }
        public int? SpecializedLicenseNumber { get; set; }
        public int? PaymentForSA { get; set; }
        public int? PaymentForIUI { get; set; }
        public int? PaymentForPCT { get; set; }
        public int? PaymentForInsemination { get; set; }
        public int? PaymentForWash { get; set; }
        public int? PaymentForConsulting { get; set; }
        public int? PaymentForIUISA { get; set; }
        public int? PaymentForcanNotBeMadeIUI { get; set; }
        public int? PaymentForCanNotBeMadeSA { get; set; }
        public int? PaymentForMorphology { get; set; }
        

        public virtual ICollection<ClinicVisits> ClinicVisitsDoctorNavigation { get; set; }
        public virtual ICollection<ClinicVisits> ClinicVisitsPreformedNavigation { get; set; }
        public virtual ICollection<ClinicVisits> ClinicVisitsMorphologyNavigation { get; set; }
    }
}
