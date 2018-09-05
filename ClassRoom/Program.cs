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
                Console.WriteLine(elev.Navn + elev.Fødselsdag + elev.Fødselsmåned);

                switch (elev.Fødselsmåned)
                {
                    case 1: case 2: case 12:
                        Console.WriteLine("Vinter");
                        break;
                    case 3: case 4: case 5:
                        Console.WriteLine("Forår");
                        break;
                    case 6: case 7: case 8:
                        Console.WriteLine("Sommer");
                        break;
                    case 9: case 10: case 11:
                        Console.WriteLine("Efterår");
                        break;
                    default:
                        Console.WriteLine("Ukendt fødselsmåned");
                        break;
                }

                Console.WriteLine(klasseRum.KlasseNavn);
                Console.WriteLine(klasseRum.SemesterStart);

            }
            Console.ReadKey();
        }
    }
}

