using System;
using System.Collections.Generic;
using kartoteka.osoba;


namespace kartoteka.impl.Kartoteka
{
    public class Kartoteka
    {
        private List<Osoba> lista = new();

            public void dodaj(Osoba osoba)
            {
                lista.Add(osoba);
            }
            public void usun(Osoba osoba)
            {
                lista.Remove(osoba);
            }
            public int rozmiar()
            {
                return lista.Count();
            }
            public bool czyZawiera(Osoba osoba)
            {
                foreach (Osoba n in lista)
                {
                    if (osoba.getImie().Equals(n.getImie()) && osoba.getNazwisko().Equals(n.getNazwisko())) return true;
                }
                return false;
            }
            public Osoba pobierz(int idx)
            {
                string imie = lista[idx].getImie();
                string nazwisko = lista[idx].getNazwisko();
                return new Osoba(imie, nazwisko);
            }
    }
}
