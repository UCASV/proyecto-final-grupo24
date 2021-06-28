using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_DB
{
    public partial class VaccinationProcess
    {
        public VaccinationProcess()
        {
            SecondaryEffects = new HashSet<SecondaryEffect>();
        }

        public int Id { get; set; }
        public DateTime? RowDateTime { get; set; }
        public DateTime? VaccinationDateTime { get; set; }
        public DateTime? SeconddoseDateTime { get; set; }
        public int? SeconddoseCabin { get; set; }
        public int? IdEmployee { get; set; }
        public int? DuiCitizen { get; set; }
        public int? CabinNumber { get; set; }

        public virtual Cabin CabinNumberNavigation { get; set; }
        public virtual Citizen DuiCitizenNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
        public virtual ICollection<SecondaryEffect> SecondaryEffects { get; set; }
    }
}
