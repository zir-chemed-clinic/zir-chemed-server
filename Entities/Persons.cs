using System;
using System.Collections.Generic;
using System.Numerics;

namespace Entities
{
    public partial class Persons
    {
        public Persons()
        {
            ClinicVisits = new HashSet<ClinicVisits>();
        }

        public int PersonsId { get; set; }
        public string ManName { get; set; }
        public string WomanName { get; set; }
        public string FamilyName { get; set; }
        public string ManId { get; set; }
        public string WomanId { get; set; }
        public DateTime? ManDateBirth { get; set; }
        public DateTime? WomanDateBirth { get; set; }
        public string ManPhone { get; set; }
        public string WomanPhone { get; set; }
        public string ManEmail { get; set; }
        public string WomanEmail { get; set; }
        public string City { get; set; }
        public string Addres { get; set; }
        public DateTime? DateMarriage { get; set; }
        public int? NumberChildren { get; set; }
        public bool? Register { get; set; }
        public bool? BrothersToTfila { get; set; }
        public string ManFathersName { get; set; }
        public string WomanFathersName { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<ClinicVisits> ClinicVisits { get; set; }
    }
}
