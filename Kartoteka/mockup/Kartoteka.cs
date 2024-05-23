using System;
using kartoteka.osoba;


namespace kartoteka.mockup.Kartoteka
{
      public class Kartoteka
    {
        public void dodaj(Osoba osoba){ }
        public void usun(Osoba osoba) { }
        public int rozmiar()
        {
            return 1;
        }
        public bool czyZawiera(Osoba osoba)
        {
            return true;
        }
        public Osoba pobierz(int index)
        {
            return new Osoba("Gall", "Anonim");
        }
    }
 }
