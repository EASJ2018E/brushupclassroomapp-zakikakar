﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {
        public string KlasseNavn { get; set; }
        public List<Studerende> Klasseliste { get; set; }
        public DateTime SemesterStart { get; set; }

        public KlasseRum()
        {
        }

        public override string ToString()
        {
            return KlasseNavn + Klasseliste + SemesterStart;
        }

        public void Antalføds()
        {
         //   var Vinter = 
        }
    }
}
