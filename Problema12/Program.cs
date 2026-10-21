Console.Write("¿El solicitante tiene empleo? (si/no): ");
string tieneEmpleo = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();

if (tieneEmpleo is not ("si" or "sí" or "no"))
{
    throw new ArgumentException("Respuesta de empleo no válida");
}

if (tieneEmpleo == "no")
{
    Console.WriteLine("Crédito rechazado");
}
else
{
    Console.Write("Ingrese el ingreso mensual: ");
    decimal ingreso = decimal.Parse(Console.ReadLine()!);
    Console.WriteLine(ingreso >= 2_500_000
        ? "Crédito alto aprobado"
        : "Crédito básico aprobado");
}
