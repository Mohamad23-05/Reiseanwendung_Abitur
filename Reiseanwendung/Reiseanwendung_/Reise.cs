using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiseanwendung_
{
    internal class Reise
    {
        // Attribute
        private Ort start, ziel;
        private Auto auto;

        // Konstruktor
        public Reise(Ort s, Ort z, Auto a)
        {
            this.start = s;
            this.ziel = z;
            this.auto = a;
        }

        // Get- und Set-Methoden
        public Ort getStartort()
        {
            return this.start;
        }

        public Ort getZielort()
        {
            return this.ziel;
        }
        public Auto GetAuto()
        {
            return this.auto;
        }


        // Berechnung der Entfernung in Kilometern zwischen Start- und Zielort
        //Bitte nichts ändern
        //https://de.wikipedia.org/wiki/Orthodrome#Kurswinkel_und_rechtweisende_Kurse
        public double berechneEntfernung()
        {
            double sin1 = Math.Sin(start.getBreitengrad() * (Math.PI / 180));
            double sin2 = Math.Sin(ziel.getBreitengrad() * (Math.PI / 180));
            double cos1 = Math.Cos(start.getBreitengrad() * (Math.PI / 180));
            double cos2 = Math.Cos(ziel.getBreitengrad() * (Math.PI / 180));
            double cos3 = Math.Cos((ziel.getLaengengrad() - start.getLaengengrad()) * (Math.PI / 180));

            double zw = Math.Acos((sin1 * sin2) + (cos1 * cos2 * cos3)) * (180 / Math.PI);
            return (zw * 40075) / 360;
        }

        // Methode zur Berechnung der Reisezeit anhand der Entfernung und der Geschwindigkeit des Autos
        public double berechneReisezeit(double d)
        {
            return d / auto.getGeschwindigkeit();
        }
    }
}
