using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Transport
    {
        public string ID
        { get; set; }

        public string Plecare
        { get; set; }

        public string Destinatie
        { get; set; }

        public string Companie
        { get; set; }

        public string Descriere
        { get; set; }

        public Decimal DurataZbor
        { get; set; }

        public override string ToString()
        {
            return "--------------------" +
                "TRANSPORT: \n" +
                "\n Plecare: "+ Plecare +
                "\n Destinatie: " + Destinatie + 
                "\n Compania aeriana: " + Companie +
                "\n Durata zbor: " + DurataZbor + 
                "\n Descriere:  " +Descriere +
                 "\n";
        }
    }
}
