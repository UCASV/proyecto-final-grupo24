using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_DB
{
    public partial class Employee
    {
        public Employee()
        {
            Appointments = new HashSet<Appointment>();
            Citizens = new HashSet<Citizen>();
            Registries = new HashSet<Registry>();
            VaccinationProcesses = new HashSet<VaccinationProcess>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordUser { get; set; }
        public string InstitutionalMail { get; set; }
        public string AddresUser { get; set; }
        public string NameUser { get; set; }
        public string LastnameUser { get; set; }
        public int? IdTypeEmployee { get; set; }

        public virtual TypeEmployee IdTypeEmployeeNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Citizen> Citizens { get; set; }
        public virtual ICollection<Registry> Registries { get; set; }
        public virtual ICollection<VaccinationProcess> VaccinationProcesses { get; set; }
    }
}
