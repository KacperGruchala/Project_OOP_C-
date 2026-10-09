using System;
using System.Collections.Generic;
using System.Text;

namespace Zestaw_3
{
    /// <summary>
    /// Interfejs definiujący podstawowe właściwości i metody dla każdego obiektu przeznaczonego do sprzedaży.
    /// </summary>
    public interface ISprzedaz
    {
        /// <summary>
        /// Właściwości wymagane przez interfejs
        /// </summary>
        string Kod { get; set; }
        double Cena { get; }
        string Nazwa { get; }
        /// <summary>
        /// Wyświetla szczegółowe informacje o produkcie w konsoli.
        /// </summary>
        void WyswietlSzczegoly();
    }
}
