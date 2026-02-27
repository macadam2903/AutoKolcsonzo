using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKolcsonzes
{
    public class Kolcsonzesek
    {
        public int KolcsonzesSzama { get; set; }
        public string Ugyfel { get; set; }
        public string Rendszam { get; set; }   // <-- új
        public string AutoMarka { get; set; }
        public string AutoModell { get; set; }
        public int NapiDij { get; set; }
        public DateTime Mettol { get; set; }
        public DateTime Meddig { get; set; }

        public Kolcsonzesek(int kolcsonzesSzama, string ugyfel, string rendszam,
                            string autoMarka, string autoModell,
                            int napiDij, DateTime mettol, DateTime meddig)
        {
            KolcsonzesSzama = kolcsonzesSzama;
            Ugyfel = ugyfel;
            Rendszam = rendszam;   // <-- új
            AutoMarka = autoMarka;
            AutoModell = autoModell;
            NapiDij = napiDij;
            Mettol = mettol;
            Meddig = meddig;
        }
    }
}
