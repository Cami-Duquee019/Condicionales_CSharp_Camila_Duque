using System.Globalization;

Console.Write("Ingrese la primera nota (0-100): ");
decimal nota1 = decimal.Parse(Console.ReadLine()!, CultureInfo.CurrentCulture);

Console.Write("Ingrese la segunda nota (0-100): ");
decimal nota2 = decimal.Parse(Console.ReadLine()!, CultureInfo.CurrentCulture);

Console.Write("Ingrese la tercera nota (0-100): ");
decimal nota3 = decimal.Parse(Console.ReadLine()!, CultureInfo.CurrentCulture);

if (nota1 is < 0 or > 100 || nota2 is < 0 or > 100 || nota3 is < 0 or > 100)
{
    throw new ArgumentOutOfRangeException(nameof(nota1), "Las notas deben estar entre 0 y 100");
}

decimal promedio = (nota1 + nota2 + nota3) / 3;
char letra = promedio switch
{
    >= 90 => 'A',
    >= 80 => 'B',
    >= 70 => 'C',
    >= 60 => 'D',
    _ => 'F'
};

string retroalimentacion = letra switch
{
    'A' => "Desempeño excelente",
    'B' or 'C' => "Buen desempeño, sigue así",
    'D' => "Aprobado, refuerza los temas",
    _ => "Debe presentar plan de mejoramiento"
};

string estado = promedio >= 60 ? "Aprobado" : "Reprobado";
CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");
Console.WriteLine($"Promedio: {promedio.ToString("F1", cultura)} | Letra: {letra} | {retroalimentacion} | {estado}");

if (promedio == 100)
{
    Console.WriteLine("¡Mención de honor!");
}
