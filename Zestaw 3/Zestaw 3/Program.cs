namespace Zestaw_3
{
    /// <summary>
    /// Główna klasa uruchomieniowa programu prezentująca działanie automatu.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Inicjalizacja automatu
            Automat automat = new Automat();
            // 1. Tworzenie obiektów klasy Napoj
            Napoj cola = new Napoj("Coca Cola", 4.50, "A1", 500);
            Napoj woda = new Napoj("Woda Gazowana", 2.00, 330);
            woda.Kod = "A2";
            // 2. Tworzenie obiektów klasy Przekaska
            Przekaska chipsy = new Przekaska("Chipsy", 6.20, "B1", 140);
            Przekaska czekolada = new Przekaska("Czekolada", 5.50, "B2", 100);
            // 3. Tworzenie obiektów nowej klasy Slodycz
            Slodycz baton = new Slodycz("Baton", 3.20, "C1", true);
            Slodycz zelki = new Slodycz("Żelki", 4.80, false);
            zelki.Kod = "C2"; // Użycie settera po konstruktorze przeciążonym
            // Dodawanie wszystkich obiektów do listy asortymentu automatu
            automat.DodajProdukt(cola);
            automat.DodajProdukt(woda);
            automat.DodajProdukt(chipsy);
            automat.DodajProdukt(czekolada);
            automat.DodajProdukt(baton);
            automat.DodajProdukt(zelki);
            automat.WyswietlKatalog();
            Console.WriteLine("--> Próba zakupu chipsów (B1) za 10.00 zl:");
            automat.KupProdukt("B1", 10.00);
            Console.WriteLine("--> Próba zakupu batona (C1) za 5.00 zl:");
            automat.KupProdukt("C1", 5.00);
            automat.WyswietlKatalog();
            Console.WriteLine("--> Próba zakupu żelków (C2) za 2.00 zl:");
            automat.KupProdukt("C2", 2.00);
        }
    }
}