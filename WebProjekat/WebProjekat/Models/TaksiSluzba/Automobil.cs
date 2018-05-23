using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProjekat.Models.TaksiSluzba
{
    public class Automobil
    {
        public Korisnik Vozac { get; set; }
        public int Godiste { get; set; }
        public string BrojVozila { get; set; }
        public TipAutomobila TipAutomobila { get; set; }
    }
}