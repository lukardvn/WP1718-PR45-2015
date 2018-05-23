using System;

namespace WebProjekat.Models.TaksiSluzba
{
    public class Voznja
    {
        static int brInstanci = 0;
        public int ID { get; set; }
        public DateTime DatumPorudzbine { get; set; }
        public Lokacija PocetnaLokacija { get; set; }
        public TipAutomobila TipAutomobila { get; set; }
        public Musterija Musterija { get; set; }
        public Lokacija Odrediste { get; set; }
        public Dispecer Dispecer { get; set; }
        public double Iznos { get; set; }
        public Komentar Komentar { get; set; }
        public StatusVoznje Status { get; set; }

        public Voznja (int id = 0)
        {
            if (id == 0)
            {
                brInstanci++;
                ID = brInstanci;
            }
        }
    }
}