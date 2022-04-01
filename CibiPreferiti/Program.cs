string[] cibiPreferiti = { "Pasticcio", "Spaghetti", "Mille foglie","Costicine con salsa barbecue" , "Pollo fritto speziato" };

Console.WriteLine("La lunghezza della classifica è: "+cibiPreferiti.Length);

Console.WriteLine("\nLa lista dei cibi é: ");
foreach (string cibo in cibiPreferiti)
{
    Console.WriteLine(cibo);
}

Console.WriteLine("\nIl mio cibo preferito è: ");
Console.WriteLine(cibiPreferiti[0]);

Console.WriteLine("\nIl mio cibo preferito ma non tanto quanto gli altri è: ");
Console.WriteLine(cibiPreferiti[cibiPreferiti.Length-1]);