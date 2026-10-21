Console.Write("Ingrese el primer número entero: ");
int primero = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el segundo número entero: ");
int segundo = int.Parse(Console.ReadLine()!);

int mayor = primero > segundo ? primero : segundo;
Console.WriteLine($"El mayor es {mayor}");
