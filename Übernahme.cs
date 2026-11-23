using System;
using System.Threading;

class Program
{
    static Random zufall = new Random();

    static void Main()
    {
        Console.Title = "Absolut normales Programm";
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Schreiben("System wird gestartet ...");
        Thread.Sleep(700);

        Schreiben("Unbekanntes Gerät erkannt: ENTE");
        Schreiben("Ente fordert Administratorrechte an ...");
        Thread.Sleep(1000);

        Console.ForegroundColor = ConsoleColor.Red;
        Schreiben("ANFRAGE ABGELEHNT.");
        Thread.Sleep(700);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Schreiben("Der Ente ist das egal.");
        Thread.Sleep(1200);

        Console.ForegroundColor = ConsoleColor.Green;
        Laden("Zusätzlichen Arbeitsspeicher herunterladen");
        Laden("Hausaufgaben in Entenbilder umwandeln");
        Laden("Lehrer auf stumm schalten");

        Console.WriteLine();
        Schreiben("Enten-Geheimdienst wird kontaktiert ...");

        for (int i = 0; i < 18; i++)
        {
            Console.WriteLine(
                "[QUAK-" + zufall.Next(1000, 10000) + "] " +
                "192.168." + zufall.Next(0, 256) + "." +
                zufall.Next(1, 255) + " ... QUAK BESTÄTIGT"
            );

            Thread.Sleep(90);
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Schreiben("WARNUNG: KRITISCHER ENTENFEHLER!");
        Thread.Sleep(1200);

        for (int i = 5; i > 0; i--)
        {
            Console.Clear();
            Console.WriteLine("\n\n    COMPUTERÜBERNAHME IN:");
            Console.WriteLine("\n             " + i);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;

        Schreiben("QUAK.");
        Thread.Sleep(1500);

        Schreiben("Dein Computer gehört jetzt einer Ente.");
        Schreiben("Sie verlangt 3 Scheiben Brot als Lösegeld.");
        Thread.Sleep(1300);

        Console.ForegroundColor = ConsoleColor.Cyan;
        Schreiben("\nVerhandlung erfolgreich.");
        Schreiben("Die Ente akzeptiert auch einen Döner.");

        Console.ResetColor();
        Console.WriteLine("\nEnter drücken, um die Simulation zu beenden.");
        Console.ReadLine();
    }

    static void Schreiben(string text)
    {
        foreach (char zeichen in text)
        {
            Console.Write(zeichen);
            Thread.Sleep(25);
        }

        Console.WriteLine();
    }

    static void Laden(string aufgabe)
    {
        Console.WriteLine();

        for (int prozent = 0; prozent <= 100; prozent += 5)
        {
            int anzahl = prozent / 5;

            string balken =
                new string('#', anzahl) +
                new string('-', 20 - anzahl);

            Console.Write(
                "\r" + aufgabe + " [" + balken + "] " +
                prozent + "%   "
            );

            Thread.Sleep(zufall.Next(30, 120));
        }

        Console.WriteLine();
    }
}
