using System;
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
            var queryAntalføds = from studerende in Klasseliste group studerende by studerende.Årstider();

            // Kør foreach på queryAntalføds (indeholder de 4 årstider)
            // dvs. vores foreach kører 4 gange
            foreach (IGrouping<string, Studerende> årstid in queryAntalføds)
            {
                Console.WriteLine("Der er " + årstid.Count() + " der har fødselsdag til " + årstid.Key);
            }
        }
    }
}
