using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emmerson_Erweiterung_Verschiedene_Anbieter {
    internal class Artikel {
        private string bezeichnung;
        private double preis;
        private string abgabeeinheit;

        public void setBezeichnung(string bezeichnung) {
            this.bezeichnung = bezeichnung;
        }

        public string getBezeichnung() {  
            return this.bezeichnung; 
        }

        public double getPreis() {
            return this.preis;
        }

        public void setPreis(double preis) {
            this.preis = preis;
        }

        public void setAbgabeeinheit(string abgabeeinheit) {
            this.abgabeeinheit = abgabeeinheit;
        }

        public string getAbgabeeinheit() {
            return abgabeeinheit;
        }

        // Konstruktor
        public Artikel(string bezeichnung, double preis, string abgabeeinheit) {
            this.bezeichnung=bezeichnung;
            this.preis=preis;
            this.abgabeeinheit=abgabeeinheit;
        }
    }
}
