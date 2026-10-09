using System;
using System.Collections.Generic;
using System.Text;

namespace Zestaw_3
{

    /// <summary>
    /// Abstrakcyjna klasa bazowa reprezentująca ogólny produkt. Implementuje interfejs ISprzedaz.
    /// </summary>
    public abstract class Produkt : ISprzedaz
    {
        /// <summary>
        /// Pola w klasie (private oraz protected)
        /// </summary>
        private string nazwa;
        private double cena;
        protected string kod;

        /// <summary>
        /// Właściwości z getterami i setterami (get i set)
        /// </summary>
        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = string.IsNullOrWhiteSpace(value) ? "Nieznany Produkt" : value; }
        }

        public double Cena
        {
            get { return cena; }
            private set { cena = value >= 0 ? value : 0.0; } // Walidacja ceny
        }

        public string Kod
        {
            get { return kod; }
            set { kod = value.ToUpper(); }
        }

        public Kategoria Kategoria { get; protected set; }

        /// <summary>
        /// Główny konstruktor
        /// </summary>
        /// <param name="nazwa">Nazwa produktu</param>
        /// <param name="cena">Cena produktu</param>
        /// <param name="kod">Kod produktu</param>
        /// <param name="kategoria">Kategoria produktu</param>
        public Produkt(string nazwa, double cena, string kod, Kategoria kategoria)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.kod = kod;
            this.Kategoria = kategoria;
        }

        /// <summary>
        /// Przeciążenie konstruktora - domyślny kod "00"
        /// </summary>
        /// <param name="nazwa">Nazwa produktu</param>
        /// <param name="cena">Cena produktu</param>
        /// <param name="kategoria">Kategoria produktu</param>
        public Produkt(string nazwa, double cena, Kategoria kategoria)
            : this(nazwa, cena, "00", kategoria)
        {
        }

        /// <summary>
        /// Metoda wyświetlająca szczegóły produktu
        /// </summary>
        public virtual void WyswietlSzczegoly()
        {
            Console.WriteLine($"[{Kod}] {Nazwa} - Cena: {Cena:F2} zl | Kategoria: {Kategoria}");
        }
    }
}
