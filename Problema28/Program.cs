using System.Globalization;

Console.Write("Ingrese el valor de la compra: ");
decimal compra = decimal.Parse(
    (Console.ReadLine() ?? string.Empty).Replace(',', '.'),
    CultureInfo.InvariantCulture);
if (compra < 0)
{
    throw new ArgumentOutOfRangeException(nameof(compra), "El valor de la compra no puede ser negativo");
}

Console.Write("¿Es cliente frecuente? (si/no): ");
string respuestaFrecuente = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
if (respuestaFrecuente is not ("si" or "sí" or "no"))
{
    throw new ArgumentException("Respuesta de cliente frecuente no válida");
}

decimal descuento = compra switch
{
    >= 500_000 => 0.15m,
    >= 200_000 => 0.10m,
    >= 100_000 => 0.05m,
    _ => 0m
};

bool esFrecuente = respuestaFrecuente is "si" or "sí";
if (esFrecuente && compra >= 100_000)
{
    descuento += 0.05m;
}

decimal total = compra * (1 - descuento);
CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");
Console.WriteLine($"Valor de compra: ${compra.ToString("N0", cultura)}");
Console.WriteLine($"Descuento total: {(descuento * 100).ToString("0", cultura)} %");
Console.WriteLine($"Total a pagar: ${total.ToString("N0", cultura)}");
