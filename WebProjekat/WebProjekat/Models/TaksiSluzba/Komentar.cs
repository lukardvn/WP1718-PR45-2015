using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProjekat.Models.TaksiSluzba
{
    public class Komentar
    {
        static int brInstanci = 0;

        public int ID { get; set; }
        public string Opis { get; set; }
        public DateTime Datum { get; set; }
        public Korisnik Autor { get; set; }
        public Voznja Voznja { get; set; }
        public int Ocena { get; set; }

        public Komentar(int id = 0)
        {
            if (id == 0)
            {
                brInstanci++;
                ID = brInstanci;
            }
        }
    }
}