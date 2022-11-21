using System;
using System.Collections.Generic;

namespace Hackat_Orga.Models
{
    public partial class Evenement
    {
        public int Id { get; set; }
        public string Libelle { get; set; } = null!;
        public DateOnly DateEvent { get; set; }
        public TimeOnly Heure { get; set; }
        public TimeOnly Duree { get; set; }
        public string Salle { get; set; } = null!;
    }
}
