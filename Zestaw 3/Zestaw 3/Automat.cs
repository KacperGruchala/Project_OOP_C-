using System;
using System.Collections.Generic;
using System.Text;

namespace Zestaw_3
{
    /// <summary>
    /// Klasa reprezentująca automat przechowujący i sprzedający produkty.
    /// </summary>
    public class Automat
    {
        // Dodawanie obiektów do listy obiektów (lista przechowuje interfejs ISprzedaz)
        private List<ISprzedaz> asortyment = new List<ISprzedaz>();
        /// <summary>
        /// Dodaje nowy produkt do asortymentu automatu.
        /// </summary>
        public void DodajProdukt(ISprzedaz produkt)
        {
            asortyment.Add(produkt);
        }
        /// <summary>
        /// Wyświetla aktualną listę produktów w automacie.
        /// </summary>
        public void WyswietlKatalog()
        {
            Console.WriteLine("\n=== KATALOG AUTOMATU ===");
            if (asortyment.Count == 0)
            {
                Console.WriteLine("Automat jest pusty.");
                return;
            }
            foreach (var produkt in asortyment)
            {
                produkt.WyswietlSzczegoly();
            }
            Console.WriteLine("========================\n");
        }
        /// <summary>
        /// Proces zakupu produktu na podstawie kodu.
        /// </summary>
        public void KupProdukt(string kod, double wrzuconePieniadze)
        {
            // Wyszukiwanie obiektu w liście
            ISprzedaz produkt = asortyment.Find(p => p.Kod.Equals(kod, StringComparison.OrdinalIgnoreCase));
            if (produkt == null)
            {
                Console.WriteLine($"[BLAD] Produkt o kodzie {kod} nie istnieje.");
                return;
            }
            if (wrzuconePieniadze < produkt.Cena)
            {
                Console.WriteLine($"[BLAD] Za malo pieniedzy. {produkt.Nazwa} kosztuje {produkt.Cena:F2} zl. Wrzucono: {wrzuconePieniadze:F2} zl.");
                return;
            }
            double reszta = wrzuconePieniadze - produkt.Cena;
            Console.WriteLine($"[SUKCES] Kupiono: {produkt.Nazwa}! Wydano reszte: {reszta:F2} zl.");
            asortyment.Remove(produkt); // Usunięcie zakupionego obiektu z listy
        }
    }
}
