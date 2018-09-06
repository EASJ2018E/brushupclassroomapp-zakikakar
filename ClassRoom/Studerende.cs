using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        private int _fødselsmåned;
        public string Navn { get; set; }

        public int Fødselsmåned
        {
            get => _fødselsmåned;
            set
            {
                if (value >=1 && value <=12)
                {
                    _fødselsmåned = value;
                }
                else
                {
                    throw new Exception("Ukendt måned");
                }
            }
        }

        public int Fødselsdag { get; set; }

        public Studerende(string navn, int fødselsmåned, int fødselsdag)
        {
            Navn = navn;
            Fødselsmåned = fødselsmåned;
            Fødselsdag = fødselsdag;
        }

        

        public string Årstider()
        {
            string årstider = null;

            switch (Fødselsmåned)
            {
                case 1:
                case 2:
                case 12:
                    årstider = "Vinter";
                    break;
                case 3:
                case 4:
                case 5:
                    årstider = "Forår";
                    break;
                case 6:
                case 7:
                case 8:
                    årstider = "Sommer";
                    break;
                case 9:
                case 10:
                case 11:
                    årstider = "Efterår";
                    break;
            }
            return årstider;

        }

    }
}
