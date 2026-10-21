Console.Write("Ingrese el nivel de batería (0-100): ");
int nivelBateria = int.Parse(Console.ReadLine()!);

if (nivelBateria < 15)
{
    Console.WriteLine("Batería baja: conecte el cargador");
}

Console.WriteLine($"Nivel actual: {nivelBateria} %");
