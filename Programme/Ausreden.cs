using System;

class Program
{
    static void Main()
    {
        Random zufall = new Random();

        string[] personen =
        {
            "Mein Hamster",
            "Ein Hacker",
            "Meine Oma",
            "Eine Ente",
            "Mein Staubsaugerroboter",
            "Der Nachbar"
        };

        string[] aktionen =
        {
            "hat meine Hausaufgaben gegessen",
            "hat meinen Laptop nach Australien geschickt",
            "hat mein WLAN geklaut",
            "hat meine Dateien gelöscht",
            "hat meine Schultasche versteckt",
            "hat meinen Computer in eine Mikrowelle verwandelt"
        };

        string[] gruende =
        {
            "weil das Internet es verlangt hat.",
            "um die Weltherrschaft zu übernehmen.",
            "weil ihm langweilig war.",
            "aus Protest gegen den Montag.",
            "und behauptet jetzt, ich sei schuld.",
            "Das steht sogar so im Polizeibericht."
        };

        Console.Title = "Der ultimative Ausreden-Generator";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=== AUSREDEN-GENERATOR 3000 ===");
        Console.ResetColor();

        while (true)
        {
            Console.WriteLine("\nEnter = neue Ausrede | Q = beenden");

            if (Console.ReadKey(true).Key == ConsoleKey.Q)
            {
                break;
            }

            string ausrede =
                personen[zufall.Next(personen.Length)] + " " +
                aktionen[zufall.Next(aktionen.Length)] + ", " +
                gruende[zufall.Next(gruende.Length)];

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + ausrede);
            Console.ResetColor();

            Console.WriteLine(
                "Glaubwürdigkeit: " + zufall.Next(0, 101) + " %"
            );
        }
    }
}