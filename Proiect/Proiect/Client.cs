using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Client
    {
        public string ID
        { get; set; }

        public string Name  
        { get; set; }

        public string Prenume
        { get; set; }


        public string Adresa
        { get; set; }


        public string Telefon
        { get; set; }


        public string SerieCI
        { get; set; }


        public string Email
        { get; set; }


        public string Data
        { get; set; }

        public override string ToString()
        {
            return "--------------------" +
                "CLIENT: \n" +
                "Nume: " +Name + 
                "\n Prenume: " + Prenume + 
                "\n Adresa: " + Adresa + 
                "\n Telefon:  " + Telefon + 
                "\n SerieCI " +SerieCI + " \n"+
                "Email: " + Email + 
                "\n Data nastere:  " + Data +
                "\n";
        }
    }
}
