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

//Bonus
Console.WriteLine("\n--Bonus--");
if (cibiPreferiti.Length % 2 != 0)  //Controllo se è dispari, se lo è solo un valore sarà veramente centrale altrimenti due valori saranno centrali
{   
    Console.WriteLine("\nValore di mediana se array è dispari: ");
    Console.WriteLine(cibiPreferiti[cibiPreferiti.Length / 2]);
}
else
{
    Console.WriteLine("\nValore di mediana se array è pari: ");
    Console.WriteLine(cibiPreferiti[cibiPreferiti.Length / 2]);
    Console.WriteLine(cibiPreferiti[cibiPreferiti.Length / 2 + 1]);
}
