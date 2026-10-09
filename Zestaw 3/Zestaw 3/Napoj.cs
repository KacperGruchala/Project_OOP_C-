using System;
using System.Collections.Generic;
using System.Text;

namespace Zestaw_3
{
    /// <summary>
    /// Klasa reprezentująca napój, dziedzicząca po klasie Produkt.
    /// </summary>
    public class Napoj : Produkt
    {
        /// <summary>
        /// Nowa właściwość specyficzna dla napojów
        /// </summary>
        private int pojemnoscMl { get; set; }
        /// <summary>
        /// Konstruktor główny korzystający z konstruktora bazy
        /// </summary>
        /// <param name="nazwa">Nazwa napoju</param>
        /// <param name="cena">Cena napoju</param>
        /// <param name="kod">Kod napoju</param>
        /// <param name="pojemnoscMl">Pojemność napoju w mililitrach</param>
        public Napoj(string nazwa, double cena, string kod, int pojemnoscMl)
            : base(nazwa, cena, kod, Kategoria.Napoj)
        {
            this.pojemnoscMl = pojemnoscMl;
        }
        /// <summary>
        /// Konstruktor przeciążony dla napoju
        /// </summary>
        /// <param name="nazwa">Nazwa napoju</param>
        /// <param name="cena">Cena napoju</param>
        /// <param name="pojemnoscMl">Pojemność napoju w mililitrach</param>
        public Napoj(string nazwa, double cena, int pojemnoscMl)
            : base(nazwa, cena, Kategoria.Napoj)
        {
            this.pojemnoscMl = pojemnoscMl;
        }
        /// <summary>
        /// Metoda wyświetlająca szczegóły napoju
        /// </summary>
        public override void WyswietlSzczegoly()
        {
            Console.WriteLine($"[{Kod}] {Nazwa} ({pojemnoscMl}ml) - Cena: {Cena:F2} zl | Kat: {Kategoria}");
        }
    }
}
