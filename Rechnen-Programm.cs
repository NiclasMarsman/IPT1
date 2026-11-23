while (true){

Console.WriteLine("Gib mir 2 Zahlen die ich zusammenrechnen soll.");
Console.WriteLine("erste Zahl:") ;
string zahl1 = Console.ReadLine();

Console.WriteLine("zweite Zahl:");
string zahl2 = Console.ReadLine();

double zahl1Double = double.Parse(zahl1);
double zahl2Double = double.Parse(zahl2);

double sum = zahl1Double + zahl2Double;

double result = Math.Round(sum, 2);

Console.WriteLine("Die Summe ist: " + result);

}