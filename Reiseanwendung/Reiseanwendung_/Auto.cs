using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiseanwendung_
{
    public class Auto : Fortbewegungsmittel
    {
        // Attribute
        int reichweite;
        string modell, hersteller;

        //Konstruktor
        public Auto(string hersteller, string modell, int reichweite, int geschwindigkeit) : base(geschwindigkeit)
        {
            this.reichweite = reichweite;
            this.modell = modell;
            this.hersteller = hersteller;
        }

        //Get-Methoden
        public string getHersteller()
        {
            return this.hersteller;
        }
        public string getModell()
        {
            return this.modell;
        }
        public int getReichweite()
        {
            return this.reichweite;
        }
        public int getv()
        {
            return this.getGeschwindigkeit();
        }
    }
}
