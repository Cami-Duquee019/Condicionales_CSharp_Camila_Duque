using System;

Console.WriteLine("Ingrese cuantos kilos pesa su paquete: ");
float peso = float.Parse(Console.ReadLine());
if (peso <1 && peso > 0)
{
    decimal precio = 8000;
    Console.WriteLine($"{precio:C0}");
}
else if (peso >= 1 && peso <= 5)
{
    decimal precio = 15000;
        Console.WriteLine($"{precio:C0}");
}
else if (peso > 5 && peso < 20)
{
    decimal precio = 32000;
    Console.WriteLine($"{precio:C0}");
}
else if (peso >= 20)
{
    decimal precio = 60000;
    Console.WriteLine($"{precio:C0}");
}
else
{
    Console.WriteLine("Peso inválido.");
}