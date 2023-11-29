using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reiseanwendung_
{
    public class Ort
    {
        // Property (ohne set-Methode)
        public string Name { get; }

        // Attribute
        private double breitengrad;
        private double laengengrad;

        // Konstruktoren
        public Ort(string n)
        {
            this.Name = n;
        }

        public Ort(string n, double brGr, double laeGr)
        {
            this.Name = n;
            this.breitengrad = brGr;
            this.laengengrad = laeGr;
        }

        // Set- und Get-Methoden
        public void setBreitengrad(double brGr)
        {
            this.breitengrad = brGr;
        }

        public double getBreitengrad()
        {
            return this.breitengrad;
        }

        public void setLaengengrad(double laeGr)
        {
            this.laengengrad = laeGr;
        }

        public double getLaengengrad()
        {
            return this.laengengrad;
        }
    }
}
