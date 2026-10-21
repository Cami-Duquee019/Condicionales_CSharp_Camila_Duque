using System.Globalization;

Console.Write("Ingrese el día de la semana: ");
string dia = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();

Console.Write("¿La persona es estudiante? (si/no): ");
string respuestaEstudiante = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
if (respuestaEstudiante is not ("si" or "sí" or "no"))
{
    throw new ArgumentException("Respuesta de estudiante no válida");
}

bool esEstudiante = respuestaEstudiante is "si" or "sí";
decimal precio = dia switch
{
    "martes" => 7_000,
    "lunes" or "miércoles" or "miercoles" or "jueves" or "viernes" =>
        esEstudiante ? 9_000 : 12_000,
    "sábado" or "sabado" or "domingo" => 15_000,
    _ => throw new ArgumentException("Día de la semana no válido")
};

Console.WriteLine($"${precio.ToString("N0", CultureInfo.GetCultureInfo("es-CO"))}");
