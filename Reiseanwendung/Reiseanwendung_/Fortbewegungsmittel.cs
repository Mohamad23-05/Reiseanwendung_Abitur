using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiseanwendung_
{
    public class Fortbewegungsmittel
    {
        //Attribute
        private int geschwindigkeit;

        //Konstruktur
        protected Fortbewegungsmittel(int geschwindigkeit)
        {
            this.geschwindigkeit = geschwindigkeit;
        }

        //Get - und Setter Methoden
        public int getGeschwindigkeit()
        {
            return this.geschwindigkeit;
        }
    }
}
