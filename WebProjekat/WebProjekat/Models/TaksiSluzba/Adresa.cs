namespace WebProjekat.Models.TaksiSluzba
{
    public class Adresa
    {

        public string Ulica { get; set; }
        public string Broj { get; set; }
        public string Mesto { get; set; }
        public string PozivniBroj { get; set; }

        public override string ToString()
        {
            return Ulica + " " + Broj + ", " + Mesto + " " + PozivniBroj;
        }
    }
}