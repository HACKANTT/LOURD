using System;
using System.Collections.Generic;

namespace Hackat_Orga.Models
{
    public partial class Hackaton
    {
        public Hackaton()
        {
            Inscriptions = new HashSet<Inscription>();
        }

        public int Id { get; set; }
        public DateOnly DateDebut { get; set; }
        public DateOnly DateFin { get; set; }
        public TimeOnly HeureDebut { get; set; }
        public TimeOnly HeureFin { get; set; }
        public string Lieu { get; set; } = null!;
        public string Rue { get; set; } = null!;
        public string Ville { get; set; } = null!;
        public string Cp { get; set; } = null!;
        public string Theme { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Image { get; set; } = null!;
        public DateOnly DateLimite { get; set; }
        public int NbPlaces { get; set; }

        public virtual ICollection<Inscription> Inscriptions { get; set; }
    }
}
