using AutoKolcsonzes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoKolcsonzesGUI
{
    /*
     * Asztali GUI-s feladat
Grafikus felületen valósítsa meg az alábbi funkciókat:

Autók adatainak megjelenítése: Hozzon létre egy táblázatot, amely megjeleníti az autók adatait a kolcsonzesek.csv fájlból.
Új kölcsönzés hozzáadása: Hozzon létre egy űrlapot, ahol az ügyfelek megadhatják a kölcsönzés adatait (pl. ügyfél neve, autó márkája, modellje, napi díj, kölcsönzés kezdete és vége), majd mentse el ezeket az adatokat a kolcsonzesek.csv fájlba.
Kölcsönzések szűrése: Hozzon létre egy szűrő funkciót, amely lehetővé teszi a kölcsönzések szűrését az ügyfél neve alapján.
Menü létrehozása: Hozzon létre egy menüt, amely lehetővé teszi a különböző műveletek elérését (pl. kölcsönzések száma, legdrágább kölcsönzés, legnépszerűbb autómárka stb.).
Kölcsönzések statisztikáinak megjelenítése: Hozzon létre egy külön szekciót, ahol megjelenítheti a kölcsönzések statisztikáit (pl. átlagos időtartam, összesített díj, 2025. decemberi kölcsönzések száma stb.).
    */
    public partial class Form1 : Form
    {
        List<Kolcsonzesek> kolcsonzesek = new List<Kolcsonzesek>();
        string fajl = "kolcsonzesek.csv";

        public Form1()
        {
            InitializeComponent();
            Betoltes();
        }

        void Betoltes()
        {
            kolcsonzesek.Clear();

            using (StreamReader sr = new StreamReader(fajl))
            {
                sr.ReadLine(); // fejléc

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] data = line.Split(';')
                        .Select(x => x.Trim('"'))
                        .ToArray();

                    if (data.Length < 8)
                        continue;

                    DateTime mettol;
                    DateTime meddig;

                    if (!DateTime.TryParse(data[6], out mettol))
                        continue;

                    if (!DateTime.TryParse(data[7], out meddig))
                        continue;

                    kolcsonzesek.Add(new Kolcsonzesek(
                        int.Parse(data[0]),
                        data[1],
                        data[2],
                        data[3],
                        data[4],
                        int.Parse(data[5]),
                        mettol,
                        meddig
                    ));
                }
            }

            dgvKolcsonzesek.DataSource = null;
            dgvKolcsonzesek.DataSource = kolcsonzesek;
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            int ujId = kolcsonzesek.Max(x => x.KolcsonzesSzama) + 1;

            Kolcsonzesek uj = new Kolcsonzesek(
                ujId,
                txtUgyfel.Text,
                txtRendszam.Text,
                txtMarka.Text,
                txtModell.Text,
                int.Parse(txtNapiDij.Text),
                dtpMettol.Value,
                dtpMeddig.Value
            );

            kolcsonzesek.Add(uj);

            using (StreamWriter sw = new StreamWriter(fajl, true, Encoding.UTF8))
            {
                sw.WriteLine(
                    $"\"{uj.KolcsonzesSzama}\";\"{uj.Ugyfel}\";\"{uj.Rendszam}\";\"{uj.AutoMarka}\";\"{uj.AutoModell}\";\"{uj.NapiDij}\";\"{uj.Mettol:yyyy-MM-dd}\";\"{uj.Meddig:yyyy-MM-dd}\"");
            }

            Betoltes();
        }

        private void btnSzures_Click(object sender, EventArgs e)
        {
            var szurt = kolcsonzesek
                .Where(x => x.Ugyfel.ToLower().Contains(txtSzures.Text.ToLower()))
                .ToList();

            dgvKolcsonzesek.DataSource = null;
            dgvKolcsonzesek.DataSource = szurt;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvKolcsonzesek.DataSource = null;
            dgvKolcsonzesek.DataSource = kolcsonzesek;
        }

        // ===== MENÜ STATISZTIKÁK =====

        private void kolcsonzesekSzamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Kölcsönzések száma: {kolcsonzesek.Count}");
        }

        private void legdragabbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var leg = kolcsonzesek
                .OrderByDescending(x => x.NapiDij * (x.Meddig - x.Mettol).Days)
                .First();

            MessageBox.Show($"Legdrágább: {leg.Ugyfel} - {leg.AutoMarka}");
        }

        private void legnepszerubbMarkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var marka = kolcsonzesek
                .GroupBy(x => x.AutoMarka)
                .OrderByDescending(g => g.Count())
                .First().Key;

            MessageBox.Show($"Legnépszerűbb márka: {marka}");
        }

        private void atlagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var atlag = kolcsonzesek
                .Average(x => (x.Meddig - x.Mettol).Days);

            MessageBox.Show($"Átlag időtartam: {atlag} nap");
        }

        private void osszesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var osszes = kolcsonzesek
                .Sum(x => x.NapiDij * (x.Meddig - x.Mettol).Days);

            MessageBox.Show($"Összes bevétel: {osszes} Ft");
        }

        private void decemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var db = kolcsonzesek
                .Count(x => x.Mettol.Month == 12 && x.Mettol.Year == 2025);

            MessageBox.Show($"2025 december: {db} db");
        }
    }
}