Console.Write("Ingrese el número del día de la semana (1-7): ");
int dia = int.Parse(Console.ReadLine()!);

string tipoDia = dia switch
{
    >= 1 and <= 5 => "Día hábil",
    6 or 7 => "Fin de semana",
    _ => "Día inválido"
};

Console.WriteLine(tipoDia);
