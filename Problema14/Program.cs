using System.Globalization;

Console.Write("Ingrese la nota final (0-5): ");
string entrada = (Console.ReadLine() ?? string.Empty).Replace(',', '.');
decimal nota = decimal.Parse(entrada, CultureInfo.InvariantCulture);

string estado = nota >= 3.0m ? "Aprobado" : "Reprobado";
CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");
Console.WriteLine($"Nota: {nota.ToString("0.0", cultura)} - {estado}");
