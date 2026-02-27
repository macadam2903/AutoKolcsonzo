using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKolcsonzes
{
    internal class Program
    {
        /*
         * AutoKölcsönzés feladat
        Egy több telephellyel rendelkező autókölcsönző cég szeretné megoldani a kölcsönzési folyamatot egy új szoftverrel. A cégnek több telephelye van, ahol különböző típusú autókat kínálnak bérlésre. Az ügyfelek online foglalhatnak autókat, és a rendszernek kezelnie kell a foglalásokat, az autók elérhetőségét, valamint a fizetési folyamatot.

        Asztali konzolos feladat
        A feladat egy asztali konzolos alkalmazás létrehozása, amely lehetővé teszi a következő műveleteket:

        Olvassa be az autók adatait egy fájlból: Az autók adatai kolcsonzesek.csv fájlban vannak tárolva, ahol minden sor egy autó adatait tartalmazza (pl. "kolcsonzes_szama";"ugyfel";"automarka";"automodell";"napi_dij";"mettol";"meddig")
        Írassa ki a kölcsönzések számát: A program számolja meg, hogy hány kölcsönzés történt.
        Írassa ki a legdrágább kölcsönzést: A program keresse meg és jelenítse meg a legdrágább kölcsönzést, azaz azt, amelyik a legmagasabb kölcsonzési díjat eredményezett. (A kölcsönzési díj a napi díj és a kölcsönzés időtartamának szorzata.)
        Írassa ki a legnépszerűbb autómárkát: A program határozza meg, hogy melyik autómárka volt a legnépszerűbb a kölcsönzések során. Mely autómárkát kölcsönözték a legtöbbször?
        Melyik ügyfél kölcsönözte a legtöbb autót?: A program határozza meg, hogy melyik ügyfél kölcsönözte a legtöbb autót, és jelenítse meg az ügyfél nevét és a kölcsönzések számát.
        Írassa ki a kölcsönzések átlagos időtartamát: A program számolja ki, hogy átlagosan mennyi ideig tartott egy kölcsönzés.
        Írassa ki a kölcsönzések összesített díját: A program számolja ki, hogy összesen mennyi pénzt fizettek a kölcsönzésekért.
        Írassa ki, hogy 2025. év decemberében hány kölcsönzés történt: A program számolja meg, hogy 2025. decemberében hány kölcsönzés történt.
        adott kölcsönző kölcsönzéseinek listázása: A program kérjen be egy ügyfél nevet, és jelenítse meg az adott ügyfél összes kölcsönzését, beleértve az autó márkáját, modelljét, a kölcsönzés időtartamát és a fizetendő díjat.
        Kölcsönző adatainak mentása fájlba: Az előző művelet után, és mentse el az adott ügyfél összes kölcsönzését egy új fájlba, amelynek neve az ügyfél nevéből származik (pl. "ugyfel_neve_kolcsonzesei.csv").
        */
        static void Main(string[] args)
        {
            // Olvassa be az autók adatait egy fájlból: Az autók adatai kolcsonzesek.csv fájlban vannak tárolva, ahol minden sor egy autó adatait tartalmazza (pl. "kolcsonzes_szama";"ugyfel";"automarka";"automodell";"napi_dij";"mettol";"meddig")
            List<Kolcsonzesek> kolcsonzesek = new List<Kolcsonzesek>();
            using (StreamReader sr = new StreamReader("kolcsonzesek.csv"))
            {
                string line;
                sr.ReadLine(); // fejléc átugrása
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(';')
                                        .Select(x => x.Trim('"'))
                                        .ToArray();

                    int kolcsonzesSzama = int.Parse(data[0]);
                    string ugyfel = data[1];
                    string rendszam = data[2];        // <-- új
                    string autoMarka = data[3];
                    string autoModell = data[4];
                    int napiDij = int.Parse(data[5]);
                    DateTime mettol = DateTime.Parse(data[6]);
                    DateTime meddig = DateTime.Parse(data[7]);

                    Kolcsonzesek kolcsonzes = new Kolcsonzesek(
                        kolcsonzesSzama,
                        ugyfel,
                        rendszam,
                        autoMarka,
                        autoModell,
                        napiDij,
                        mettol,
                        meddig);

                    kolcsonzesek.Add(kolcsonzes);
                }



            }
            // Írassa ki a kölcsönzések számát: A program számolja meg, hogy hány kölcsönzés történt.
            Console.WriteLine("Kölcsönzések száma: " + kolcsonzesek.Count);
            Console.WriteLine(
                "Legdrágább kölcsönzés: " + kolcsonzesek.OrderByDescending(k => k.NapiDij * (k.Meddig - k.Mettol).Days).First().KolcsonzesSzama);
            Console.WriteLine(
                "Legnépszerűbb autómárka: " + kolcsonzesek.GroupBy(k => k.AutoMarka).OrderByDescending(g => g.Count()).First().Key);
            Console.WriteLine(
                "Legtöbb autót kölcsönző ügyfél: " + kolcsonzesek.GroupBy(k => k.Ugyfel).OrderByDescending(g => g.Count()).First().Key);
            Console.WriteLine(
                "Kölcsönzések átlagos időtartama: " + kolcsonzesek.Average(k => (k.Meddig - k.Mettol).Days));
            Console.WriteLine(
                "Kölcsönzések összesített díja: " + kolcsonzesek.Sum(k => k.NapiDij * (k.Meddig - k.Mettol).Days));
            Console.WriteLine(
                "2025. decemberi kölcsönzések száma: " + kolcsonzesek.Count(k => k.Mettol.Month == 12 && k.Mettol.Year == 2025));
            Console.WriteLine("Adja meg egy ügyfél nevét: ");
            string ugyfelNev = Console.ReadLine();
            var ugyfelKolcsonzesei = kolcsonzesek.Where(k => k.Ugyfel == ugyfelNev).ToList();
            Console.WriteLine("Kölcsönzései: ");
            Console.WriteLine(
                "KolcsonzesSzama;AutoMarka;AutoModell;Kölcsönzés időtartama;Fizetendő díj");
            foreach (var kolcsonzes in ugyfelKolcsonzesei)
            {
                Console.WriteLine(
                    $"{kolcsonzes.KolcsonzesSzama};{kolcsonzes.AutoMarka};{kolcsonzes.AutoModell};{(kolcsonzes.Meddig - kolcsonzes.Mettol).Days} nap;{kolcsonzes.NapiDij * (kolcsonzes.Meddig - kolcsonzes.Mettol).Days} Ft");
            }
            Console.WriteLine(
                $"Kölcsönzései mentése fájlba: {ugyfelNev}_kolcsonzesei.csv");
            string fajlNev = ugyfelNev.ToLower()
                                      .Replace(" ", "_")
                                      .Replace("á", "a")
                                      .Replace("é", "e")
                                      .Replace("í", "i")
                                      .Replace("ó", "o")
                                      .Replace("ö", "o")
                                      .Replace("ő", "o")
                                      .Replace("ú", "u")
                                      .Replace("ü", "u")
                                      .Replace("ű", "u");

            fajlNev += "_kolcsonzesei";

            using (StreamWriter sw = new StreamWriter(
                $"{fajlNev}.csv",
                false,
                Encoding.UTF8))
            {
                sw.WriteLine("KolcsonzesSzama;AutoMarka;AutoModell;Kolcsonzes idotartama;Fizetendo dij");

                foreach (var kolcsonzes in ugyfelKolcsonzesei)
                {
                    sw.WriteLine(
                        $"{kolcsonzes.KolcsonzesSzama};{kolcsonzes.AutoMarka};{kolcsonzes.AutoModell};{(kolcsonzes.Meddig - kolcsonzes.Mettol).Days} nap;{kolcsonzes.NapiDij * (kolcsonzes.Meddig - kolcsonzes.Mettol).Days} Ft");
                }
            }

        }

    }
}



