using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Activitate
    {
        public string ID
        { get; set; }

        public string Descriere
        { get; set; }

        public string Adresa
        { get; set; }

        public Decimal Pret
        { get; set; }

        public string Oras
        { get; set; }

        public override string ToString()
        {
            return
                "--------------------"+
                "ACTIVITATE: \n" +
                 "Descriere : " + Descriere + '\n' +
                "Pret :  " + Pret + '\n' +
                "Oras :  " + Oras + '\n' +
                "\n"
                ;
        }
    }
}
