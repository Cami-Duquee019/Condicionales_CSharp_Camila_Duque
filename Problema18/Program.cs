using System.Globalization;

Console.Write("Ingrese su estatura en metros: ");
double estatura = double.Parse(
    (Console.ReadLine() ?? string.Empty).Replace(',', '.'),
    CultureInfo.InvariantCulture);

Console.Write("Ingrese su edad: ");
int edad = int.Parse(Console.ReadLine()!);

Console.Write("¿Va acompañado por un adulto? (si/no): ");
string respuestaAcompanante = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
if (respuestaAcompanante is not ("si" or "sí" or "no"))
{
    throw new ArgumentException("Respuesta de acompañante no válida");
}

bool acompanado = respuestaAcompanante is "si" or "sí";
bool puedeSubir = estatura >= 1.40 && (edad >= 12 || acompanado);
Console.WriteLine(puedeSubir ? "Puede subir" : "No puede subir");
