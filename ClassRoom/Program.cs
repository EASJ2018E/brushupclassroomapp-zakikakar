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
            klasseRum.Klasseliste = new List<Studerende>();
            

            klasseRum.KlasseNavn = "3B";
            klasseRum.SemesterStart = new DateTime(2018, 4, 24);
            klasseRum.Klasseliste.Add(new Studerende("Arlid", 4, 24));
            klasseRum.Klasseliste.Add(new Studerende("Benja", 6, 18));
            klasseRum.Klasseliste.Add(new Studerende("Joey", 12, 6));

            foreach (Studerende elev in klasseRum.Klasseliste)
            {
                Console.WriteLine(elev.Navn + elev.Fødselsdag + elev.Fødselsmåned + elev.Årstider());
                Console.WriteLine(klasseRum.KlasseNavn);
                Console.WriteLine(klasseRum.SemesterStart);

            }
            Console.ReadKey();
        }
    }
}

