using System.Globalization;

Console.Write("Ingrese su peso en kilogramos: ");
double peso = double.Parse(
    (Console.ReadLine() ?? string.Empty).Replace(',', '.'),
    CultureInfo.InvariantCulture);

Console.Write("Ingrese su estatura en metros: ");
double estatura = double.Parse(
    (Console.ReadLine() ?? string.Empty).Replace(',', '.'),
    CultureInfo.InvariantCulture);
if (peso <= 0 || estatura <= 0)
{
    throw new ArgumentOutOfRangeException(nameof(estatura), "El peso y la estatura deben ser mayores que cero");
}

double imc = peso / (estatura * estatura);
string categoria = imc switch
{
    < 18.5 => "Bajo peso",
    < 25 => "Peso normal",
    < 30 => "Sobrepeso",
    _ => "Obesidad"
};

CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");
Console.WriteLine($"IMC: {imc.ToString("F1", cultura)} - {categoria}");
