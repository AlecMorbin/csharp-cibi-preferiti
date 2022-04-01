string[] cibiPreferiti = { "Pasticcio", "Spaghetti", "Mille foglie","Costicine con salsa barbecue" };

Console.WriteLine("La lunghezza della classifica è: "+cibiPreferiti.Length);

foreach (string cibo in cibiPreferiti)
{
    Console.WriteLine(cibo);
}

Console.WriteLine(cibiPreferiti[0]);

Console.WriteLine(cibiPreferiti[cibiPreferiti.Length-1]);