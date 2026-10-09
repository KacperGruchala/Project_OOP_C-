using System;
using System.Collections.Generic;
using System.Text;

namespace Zestaw_3
{
    /// <summary>
    /// Klasa reprezentująca słodycz, dziedzicząca po klasie Produkt.
    /// </summary>
    public class Slodycz : Produkt
    {
        /// <summary>
        /// Specyficzna właściwość dla słodyczy (np. informacja o alergenach)
        /// </summary>
        private bool czyZawieraOrzechy { get; set; }

        /// <summary>
        /// Konstruktor główny korzystający z konstruktora bazy
        /// </summary>
        /// <param name="nazwa">Nazwa słodyczy</param>
        /// <param name="cena">Cena słodyczy</param>
        /// <param name="kod">Kod słodyczy</param>
        /// <param name="czyZawieraOrzechy">Informacja o zawartości orzechów</param>
        public Slodycz(string nazwa, double cena, string kod, bool czyZawieraOrzechy)
            : base(nazwa, cena, kod, Kategoria.Slodycz)
        {
            this.czyZawieraOrzechy = czyZawieraOrzechy;
        }

        /// <summary>
        /// Konstruktor przeciążony dla słodyczy
        /// </summary>
        /// <param name="nazwa">Nazwa słodyczy</param>
        /// <param name="cena">Cena słodyczy</param>
        /// <param name="czyZawieraOrzechy">Informacja o zawartości orzechów</param>
        public Slodycz(string nazwa, double cena, bool czyZawieraOrzechy)
            : base(nazwa, cena, Kategoria.Slodycz)
        {
            this.czyZawieraOrzechy = czyZawieraOrzechy;
        }

        /// <summary>
        /// Metoda wyświetlająca szczegóły słodyczy
        /// </summary>
        public override void WyswietlSzczegoly()
        {
            string Alergeny = czyZawieraOrzechy ? "Zawiera orzechy" : "Bez orzechow";
            Console.WriteLine($"[{Kod}] {Nazwa} ({Alergeny}) - Cena: {Cena:F2} zl | Kat: {Kategoria}");
        }
    }
}
