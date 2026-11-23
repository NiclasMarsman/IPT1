Console.Write("Anzahl Erwachsene: ");
int erwachsene = int.Parse(Console.ReadLine());

Console.Write("Anzahl Kinder: ");
int kinder = int.Parse(Console.ReadLine());

double preisErwachsene = 12.50;
double preisKind = 7.00;

double total = erwachsene * preisErwachsene + kinder * preisKind;

Console.WriteLine($"Total: {total:F2} CHF");