using System;
using System.Collections.Generic;
using System.Text;

namespace Zestaw_3
{
    /// <summary>
    /// Klasa reprezentująca przekąskę, dziedzicząca po klasie Produkt.
    /// </summary>
    public class Przekaska : Produkt
    {
        /// <summary>
        /// Specyficzna właściwość dla przekąsek
        /// </summary>
        private double wagaGramy { get; set; }

        /// <summary>
        /// Konstruktor główny korzystający z konstruktora bazy
        /// </summary>
        /// <param name="nazwa">Nazwa przekąski</param>
        /// <param name="cena">Cena przekąski</param>
        /// <param name="kod">Kod przekąski</param>
        /// <param name="wagaGramy">Waga przekąski w gramach</param>
        public Przekaska(string nazwa, double cena, string kod, double wagaGramy)
            : base(nazwa, cena, kod, Kategoria.Przekaska)
        {
            this.wagaGramy = wagaGramy;
        }

        /// <summary>
        /// Metoda wyświetlająca szczegóły przekąski
        /// </summary>
        public override void WyswietlSzczegoly()
        {
            Console.WriteLine($"[{Kod}] {Nazwa} ({wagaGramy}g) - Cena: {Cena:F2} zl | Kat: {Kategoria}");
        }
    }
}
