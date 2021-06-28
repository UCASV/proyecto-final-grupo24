using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_DB
{
    public partial class SecondaryEffect
    {
        public int Id { get; set; }
        public int? IdProcess { get; set; }
        public string SecondaryEffect1 { get; set; }
        public int? EffectMinutes { get; set; }

        public virtual VaccinationProcess IdProcessNavigation { get; set; }
    }
}
