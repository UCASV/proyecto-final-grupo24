using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_DB
{
    public partial class Citizen
    {
        public Citizen()
        {
            Appointments = new HashSet<Appointment>();
            Diseases = new HashSet<Disease>();
            VaccinationProcesses = new HashSet<VaccinationProcess>();
        }

        public int Dui { get; set; }
        public int? Age { get; set; }
        public string NameCitizen { get; set; }
        public string LastnameCitizen { get; set; }
        public string AddressCitizen { get; set; }
        public int? Phone { get; set; }
        public string EmailCitizen { get; set; }
        public string InstitutionalIdentifier { get; set; }
        public int? IdPosition { get; set; }
        public int? IdEmployee { get; set; }

        public virtual Employee IdEmployeeNavigation { get; set; }
        public virtual Position IdPositionNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Disease> Diseases { get; set; }
        public virtual ICollection<VaccinationProcess> VaccinationProcesses { get; set; }
    }
}
