using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Varastonhallinta
{
    public class Tuote
    {
        [Key]
        public int Id { get; set; }
        public string? Tuotenimi { get; set; }
        public int Tuotteenhinta { get; set; }
        public int Varastosaldo { get; set; }

    }
}
