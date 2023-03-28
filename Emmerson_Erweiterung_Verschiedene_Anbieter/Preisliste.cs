using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emmerson_Erweiterung_Verschiedene_Anbieter {
    internal class Preisliste {
        private List<Artikel> listeArtikel = new List<Artikel>();
        private Anbieter anbieter;

        public void addArtikel(Artikel a) {
            listeArtikel.Add(a);
        }

        public void addArtikelListe(List<Artikel> al) {
            listeArtikel.AddRange(al);
        }

        public Anbieter getAnbieter() {  
            return anbieter; 
        }

        public void setAnbieter(Anbieter anbieter) {
            this.anbieter = anbieter;
        }

        public List<Artikel> getArtikelListe() {
            return listeArtikel;
        }

        // PL anzeigen
        public void preislisteAnzeigen() {
            Console.WriteLine(this.anbieter.getName());
            Console.WriteLine(  "=================================");

            foreach (Artikel einArtikel in listeArtikel) {
                Console.WriteLine(einArtikel.getBezeichnung() + "\t" + einArtikel.getPreis() + "\t" + einArtikel.getAbgabeeinheit());
            }          
        }
    }
}
