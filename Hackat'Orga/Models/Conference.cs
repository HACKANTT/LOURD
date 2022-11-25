using System;
using System.Collections.Generic;

namespace Hackat_Orga.Models
{
    public partial class Conference
    {
        public int Id { get; set; }
        public string Theme { get; set; } = null!;
        public string Intervenant { get; set; } = null!;
    }
}
