using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProjekat.Models.TaksiSluzba
{
    public enum PolOsobe
    {
        Musko,
        Zensko
    }

    public enum TipVoznje
    {
        Tarifa1,
        Tarifa2,
        Tarifa3
    }

    public enum TipNaloga
    {
        Musterija,
        Vozac,
        Dispecer
    }

    public enum StatusVoznje
    {
        Kreirana,
        Otkazana,
        Formirana,
        Obradjena,
        Prihvacena,
        Uspesna,
        Neuspesna
    }

    public enum TipAutomobila
    {
        Putnicki,
        Kombi
    }
}