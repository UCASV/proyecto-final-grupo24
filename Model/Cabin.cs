using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_DB
{
    public partial class Cabin
    {
        public Cabin()
        {
            Appointments = new HashSet<Appointment>();
            Registries = new HashSet<Registry>();
            VaccinationProcesses = new HashSet<VaccinationProcess>();
        }

        public int CabinNumber { get; set; }
        public string EmailCabin { get; set; }
        public int? Phone { get; set; }
        public string AdressCabin { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Registry> Registries { get; set; }
        public virtual ICollection<VaccinationProcess> VaccinationProcesses { get; set; }
    }
}
