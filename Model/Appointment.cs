using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_DB
{
    public partial class Appointment
    {
        public int Id { get; set; }
        public DateTime? DateHour { get; set; }
        public int? CabinNumber { get; set; }
        public int? IdEmployee { get; set; }
        public int? DuiCitizen { get; set; }

        public virtual Cabin CabinNumberNavigation { get; set; }
        public virtual Citizen DuiCitizenNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
