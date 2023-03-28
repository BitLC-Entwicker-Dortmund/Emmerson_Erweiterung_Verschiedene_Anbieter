using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emmerson_Erweiterung_Verschiedene_Anbieter {
    internal class Artikelangebot {
        private List<Preisliste> preislisten = new List<Preisliste>();

        public void addPreisliste(Preisliste preisliste) {
            preislisten.Add(preisliste);
        }

        internal void sucheNachBezeichnung(string s) {
            foreach (Preisliste einePreisliste in preislisten) {
                foreach (Artikel einArtikel in einePreisliste.getArtikelListe()) {
                    if (einArtikel.getBezeichnung().Contains(s)) {
                        Console.WriteLine(einArtikel.getBezeichnung() +"\t"+ einArtikel.getPreis() +"\t" +einArtikel.getAbgabeeinheit());
                    }
                }
            }
        }
    }
}
