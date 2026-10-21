using System.Globalization;

Console.Write("Ingrese la categoría del vehículo (M, A, B, C): ");
string entrada = (Console.ReadLine() ?? string.Empty).Trim().ToUpperInvariant();
if (entrada.Length != 1)
{
    throw new ArgumentException("Categoría desconocida");
}

char categoria = entrada[0];
int tarifa = categoria switch
{
    'M' => 0,
    'A' => 12_000,
    'B' => 25_000,
    'C' => 38_000,
    _ => throw new ArgumentException("Categoría desconocida")
};

string tarifaFormateada = tarifa.ToString("N0", CultureInfo.GetCultureInfo("es-CO"));
Console.WriteLine($"Categoría {categoria} - Tarifa: ${tarifaFormateada}");
