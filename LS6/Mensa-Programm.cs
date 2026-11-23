
 // Eingabe
  Console.WriteLine("Name des Produkts:");
string name = Console.ReadLine();
 
Console.WriteLine("Wie viel(e) " + name + "'s willst du kaufen?");
string amountText = Console.ReadLine();
 

double amount = double.Parse(amountText);
 
Console.WriteLine("Wie teuer sind / ist ein(e) " + name + "?");
string priceText = Console.ReadLine();  
 
 // Verarbeitung
double price = double.Parse(priceText);
 
    double completePrice = amount * price ;
completePrice = Math.Round(completePrice , 2);
 

 //Ausgabe
    Console.WriteLine( amount + " " + name + "  " + "Preis: " + completePrice + " CHF");
 
 
