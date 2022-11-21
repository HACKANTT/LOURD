using System;
using System.Collections.Generic;

namespace Hackat_Orga.Models
{
    public partial class Inscrit
    {
        public int Id { get; set; }
        public string Nom { get; set; } = null!;
        public string Prenom { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
