using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProjekat.Models.TaksiSluzba
{
    public class Korisnik
    {
        static int brInstanci = 0;

        public Korisnik(int id = 0)
        {
            if (id == 0)
            {
                brInstanci++;
                ID = brInstanci;
            }
        }
        public int ID { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public PolOsobe Pol {get; set; }
        public string JMBG { get; set; }
        public string KontaktTelefon { get; set; }
        public string Email { get; set; }
        public TipVoznje TipVoznje { get; set; }
    }
}