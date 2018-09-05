using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasseRum klasseRum = new KlasseRum();
            klasseRum.KlasseNavn = "3B";
            klasseRum.SemesterStart = new DateTime(4,9,2018);
            klasseRum.Klasseliste.Add(new Studerende("Arlid", 4, 24));
            klasseRum.Klasseliste.Add(new Studerende("Benja", 06, 18));
            
        }
    }
}
