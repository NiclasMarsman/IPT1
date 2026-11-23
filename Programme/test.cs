using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Title = "Flucht vor der Matheprüfung";
        Console.CursorVisible = false;

        const int breite = 40;
        const int hoehe = 14;

        Random zufall = new Random();
        var objekte = new List<(int x, int y, bool doener)>();

        string[] sprueche =
        {
            "Der Lehrer hat deine IP-Adresse!",
            "Du kannst rennen. Mathe kann schneller.",
            "Eine 6? Leider das deutsche Notensystem.",
            "Dein Taschenrechner hat gekuendigt.",
            "Diesen Stoff hatten wir angeblich schon.",
            "Die Pruefung hat eine zweite Seite.",
            "Dein WLAN hilft dir hier auch nicht."
        };

        int spieler = breite / 2;
        int leben = 3;
        int punkte = 0;
        int tick = 0;
        int doenerAnzahl = 0;

        string meldung = "Ueberlebe den Schultag!";
        bool beenden = false;

        Console.Clear();

        try
        {
            while (leben > 0 && !beenden)
            {
                // Tastatur einlesen
                while (Console.KeyAvailable)
                {
                    ConsoleKey taste = Console.ReadKey(true).Key;

                    if (taste == ConsoleKey.LeftArrow ||
                        taste == ConsoleKey.A)
                    {
                        spieler = Math.Max(0, spieler - 1);
                    }

                    if (taste == ConsoleKey.RightArrow ||
                        taste == ConsoleKey.D)
                    {
                        spieler = Math.Min(breite - 1, spieler + 1);
                    }

                    if (taste == ConsoleKey.Escape)
                    {
                        beenden = true;
                    }
                }

                // Das Spiel wird mit der Zeit schneller.
                int tempo = Math.Max(1, 5 - punkte / 250);

                if (tick % tempo == 0)
                {
                    for (int i = objekte.Count - 1; i >= 0; i--)
                    {
                        var ding = objekte[i];
                        ding.y++;

                        if (ding.y == hoehe - 1 &&
                            ding.x == spieler)
                        {
                            if (ding.doener)
                            {
                                punkte += 100;
                                doenerAnzahl++;
                                leben = Math.Min(5, leben + 1);
                                meldung = "DOENER! Deine Motivation ist zurueck.";
                            }
                            else
                            {
                                leben--;
                                meldung = sprueche[zufall.Next(sprueche.Length)];
                            }

                            objekte.RemoveAt(i);
                        }
                        else if (ding.y >= hoehe)
                        {
                            objekte.RemoveAt(i);
                        }
                        else
                        {
                            objekte[i] = ding;
                        }
                    }

                    // Neue Prüfungen und gelegentlich ein Döner
                    int menge = Math.Min(4, 1 + punkte / 300);

                    for (int i = 0; i < menge; i++)
                    {
                        objekte.Add((
                            zufall.Next(breite),
                            0,
                            zufall.Next(7) == 0
                        ));
                    }

                    punkte++;
                }

                // Spielfeld zeichnen
                char[,] feld = new char[hoehe, breite];

                for (int y = 0; y < hoehe; y++)
                    for (int x = 0; x < breite; x++)
                        feld[y, x] = ' ';

                foreach (var ding in objekte)
                    feld[ding.y, ding.x] = ding.doener ? 'D' : 'X';

                feld[hoehe - 1, spieler] = 'A';

                StringBuilder bild = new StringBuilder();

                bild.AppendLine("=== FLUCHT VOR DER MATHEPRUEFUNG ===");
                bild.AppendLine(
                    $"Punkte: {punkte} | Leben: {leben} | Doener: {doenerAnzahl}"
                    .PadRight(60)
                );

                bild.AppendLine("+" + new string('-', breite) + "+");

                for (int y = 0; y < hoehe; y++)
                {
                    bild.Append('|');

                    for (int x = 0; x < breite; x++)
                        bild.Append(feld[y, x]);

                    bild.AppendLine("|");
                }

                bild.AppendLine("+" + new string('-', breite) + "+");
                bild.AppendLine(meldung.PadRight(60));
                bild.AppendLine("A/D oder Pfeile = bewegen | ESC = Ende");

                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(bild);

                tick++;
                Thread.Sleep(45);
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("=== SCHULTAG BEENDET ===\n");
            Console.WriteLine("Punkte: " + punkte);
            Console.WriteLine("Gegessene Doener: " + doenerAnzahl);
            Console.WriteLine();

            if (beenden)
                Console.WriteLine("Du hast dich krankgemeldet.");
            else if (punkte >= 1000)
                Console.WriteLine("Legende. Der Lehrer hat jetzt Angst vor DIR.");
            else if (punkte >= 400)
                Console.WriteLine("Du wirst zum Klassensprecher der Flucht gewaehlt.");
            else
                Console.WriteLine("Erwischt. Morgen gibt es eine muendliche Pruefung.");

            Console.WriteLine("\nBeliebige Taste zum Schliessen.");
            Console.ReadKey(true);
        }
        finally
        {
            Console.ResetColor();
            Console.CursorVisible = true;
        }
    }
}