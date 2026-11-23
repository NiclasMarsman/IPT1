using System;

class Program
{
    static void Main()
    {
        string[] hinweise =
        {
            "Ich bin ein Tier.",
            "Ich habe Federn.",
            "Ich lebe oft an Seen oder Teichen.",
            "Ich kann schwimmen und habe Schwimmhäute.",
            "Ich habe einen breiten Schnabel.",
            "Ich mache «Quak, quak!»."
        };

        Console.WriteLine("=== Welches Tier bin ich? ===");
        Console.WriteLine("Errate das Tier!\n");

        for (int i = 0; i < hinweise.Length; i++)
        {
            Console.WriteLine("Hinweis " + (i + 1) + ": " + hinweise[i]);
            Console.Write("Deine Antwort: ");

            string antwort = (Console.ReadLine() ?? "").Trim();

            if (antwort.Equals("Ente", StringComparison.OrdinalIgnoreCase)
                || antwort.Equals("eine Ente", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\nRichtig! Es ist eine Ente!");
                Console.WriteLine("Du hast " + (i + 1) + " Hinweise gebraucht.");
                return;
            }

            Console.WriteLine("Leider falsch!\n");
        }

        Console.WriteLine("Die Lösung ist: Ente!");
    }
}