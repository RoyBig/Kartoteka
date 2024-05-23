using System;


namespace kartoteka.osoba
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        public Osoba(string name, string surname)
        {
            imie = name;
            nazwisko = surname;
        }
        public string getImie()
        {
            return imie;
        }
        public string getNazwisko()
        {
            return nazwisko;
        }
        public override bool Equals(Object obj)
        {
            if (!(obj is Osoba)) return false;
            Osoba osoba = (Osoba)obj;
            return osoba.getImie().Equals(this.getImie()) && osoba.getNazwisko().Equals(this.getNazwisko());
        }
    }
}
