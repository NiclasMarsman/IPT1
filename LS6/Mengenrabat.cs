Console.WriteLine("Artikel:");
string artikel = Console.ReadLine();

Console.WriteLine("Einzelpreis:");
double einzelpreis = double.Parse(Console.ReadLine());

Console.WriteLine("Menge:");
int menge = int.Parse(Console.ReadLine());

if (menge < 1)
{
    Console.WriteLine("Fehler: Ungültige Menge!");
    return;
}

double gesamtpreis = einzelpreis * menge;
double rabatt = 0;

if (menge >= 5)
{
    rabatt = 0.20;
}
else if (menge >= 3)
{
    rabatt = 0.10;
}
else
{
    rabatt = 0;
}

double rabattbetrag = gesamtpreis * rabatt;
double endpreis = gesamtpreis - rabattbetrag;

Console.WriteLine("Artikel: " + artikel);
Console.WriteLine("Gesamtpreis: " + gesamtpreis.ToString("F2") + " CHF");
Console.WriteLine("Rabatt: " + (rabatt * 100) + "%");
Console.WriteLine("Rabattbetrag: " + rabattbetrag.ToString("F2") + " CHF");
Console.WriteLine("Endpreis: " + endpreis.ToString("F2") + " CHF");