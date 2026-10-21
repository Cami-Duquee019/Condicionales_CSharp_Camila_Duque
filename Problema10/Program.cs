using System.Globalization;

Console.Write("Ingrese un texto, entero, decimal o booleano: ");
string entrada = Console.ReadLine() ?? string.Empty;
object dato;

if (bool.TryParse(entrada, out bool booleano))
{
    dato = booleano;
}
else if (int.TryParse(entrada, NumberStyles.Integer, CultureInfo.CurrentCulture, out int entero))
{
    dato = entero;
}
else if (double.TryParse(entrada, NumberStyles.Float | NumberStyles.AllowThousands,
             CultureInfo.CurrentCulture, out double decimalNumero))
{
    dato = decimalNumero;
}
else
{
    dato = entrada;
}

string descripcion = dato switch
{
    string texto => $"Texto de {texto.Length} caracteres",
    int valor => $"Entero: {valor}",
    double valor => $"Decimal: {valor}",
    bool valor => $"Booleano: {valor}",
    _ => "Tipo no reconocido"
};

Console.WriteLine(descripcion);
