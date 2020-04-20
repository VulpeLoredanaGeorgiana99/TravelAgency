using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Cazare
    {
        public string ID
        { get; set; }

        public string Nume
        { get; set; }

        public string Descriere
        { get; set; }

        public string Adresa
        { get; set; }

        public string Telefon
        { get; set; }

        public string Oras
        { get; set; }

        public Decimal Pret
        { get; set; }

        public override string ToString()
        {
            return "--------------------" +
                "CAZARE: \n" + 
                "\n Denumire cazare: " +Nume +
                "\n Descriere: " + Descriere + 
                "\n Adresa: " + Adresa +
                "\n Telefon: " + Telefon + 
                "\n Oras: "+ Oras + 
                "\n Pret: "+ Pret+"\n";
        }
    }
}
