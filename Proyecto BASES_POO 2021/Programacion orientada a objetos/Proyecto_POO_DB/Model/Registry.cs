using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_DB
{
    public partial class Registry
    {
        public int CabinNumber { get; set; }
        public int IdEmployee { get; set; }
        public DateTime? DateHour { get; set; }

        public virtual Cabin CabinNumberNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
