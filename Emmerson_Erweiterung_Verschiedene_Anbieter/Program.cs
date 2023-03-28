namespace Emmerson_Erweiterung_Verschiedene_Anbieter {
    internal class Program {
        static void Main(string[] args) {



            Preisliste pl1 = new Preisliste();
            pl1.setAnbieter(new Anbieter("Mattins shop"));
            pl1.addArtikel(new Artikel("UML-Buch", 37.99, "Stück"));
            pl1.addArtikel(new Artikel("C#-Buch", 9.99, "Stück"));
            pl1.addArtikel(new Artikel("UML-Zaubertrank", 1.99, "Liter"));

            Preisliste pl2 = new Preisliste();
            pl2.setAnbieter(new Anbieter("Tonis Power Shop"));
            pl2.addArtikel(new Artikel("UML-Buch", 29.99, "Stück"));
            pl2.addArtikel(new Artikel("SQL-Buch", 19.99, "Stück"));
            pl2.addArtikel(new Artikel("UML-Zaubertrank", 99.99, "Liter"));

            Artikelangebot aa = new Artikelangebot();
            aa.addPreisliste(pl1);
            pl1.preislisteAnzeigen();

            aa.addPreisliste(pl2);
            pl2.preislisteAnzeigen();

            Console.WriteLine();
            Console.WriteLine("======== suche nach UML-Buch ========");

            aa.sucheNachBezeichnung("UML-Buch");

            Console.Read();
        }
    }
}