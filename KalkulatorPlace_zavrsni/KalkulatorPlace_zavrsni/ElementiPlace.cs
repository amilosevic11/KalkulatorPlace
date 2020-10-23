using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorPlace_zavrsni
{
    class ElementiPlace
    {
        public double Zdravstveno { get; } = 0.165;
        public double MIOstup1 { get; set; }
        public double MIOstup2 { get; set; }
        public double netoPlaca { get; set; }
        public double odbitakZaDjecu { get; set; }
        public double Dohodak { get; set; }
        public double Porez1 { get; set; } = 0.24;
        public double Porez2 { get; set; } = 0.36;
        public double Prirez { get; set; }
        public double PrirezPorez { get; set; }
    }
}
