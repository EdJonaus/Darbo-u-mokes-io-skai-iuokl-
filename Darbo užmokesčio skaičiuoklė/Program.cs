Console.WriteLine("Iveskite dirbtu valandu skaiciu per savaite: ");
double valandos = double.Parse(Console.ReadLine());

Console.WriteLine("Iveskite valandini atlyginima: ");
double atlyginimas = double.Parse(Console.ReadLine());

double savaitesPelnas = valandos * atlyginimas;
double menesioPelnas = savaitesPelnas * 4;

Console.WriteLine("Savaites uzdarbis: " + savaitesPelnas + " $");
Console.WriteLine("Menesio uzdarbis: " + menesioPelnas + " $");