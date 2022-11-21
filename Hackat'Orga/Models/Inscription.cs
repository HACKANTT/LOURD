using System;
using System.Collections.Generic;

namespace Hackat_Orga.Models
{
    public partial class Inscription
    {
        public int Id { get; set; }
        public string NumInscription { get; set; } = null!;
        public DateOnly DateInscription { get; set; }
        public int IdHId { get; set; }
        public int IdUId { get; set; }

        public virtual Hackaton IdH { get; set; } = null!;
        public virtual Utilisateur IdU { get; set; } = null!;
    }
}
