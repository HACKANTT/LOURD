using System;
using System.Collections.Generic;

namespace Hackat_Orga.Models
{
    public partial class Utilisateur
    {
        public Utilisateur()
        {
            Inscriptions = new HashSet<Inscription>();
        }

        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string Tel { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public DateOnly DateNaissance { get; set; }
        public string LienPortfolio { get; set; } = null!;

        public virtual ICollection<Inscription> Inscriptions { get; set; }
    }
}
