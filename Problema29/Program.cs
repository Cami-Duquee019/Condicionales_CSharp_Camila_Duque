Console.Write("Ingrese su rol (admin, instructor, aprendiz): ");
string rol = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();

Console.Write("Ingrese la hora de llegada (0-23): ");
int hora = int.Parse(Console.ReadLine()!);
if (hora is < 0 or > 23)
{
    throw new ArgumentOutOfRangeException(nameof(hora), "La hora debe estar entre 0 y 23");
}

bool accesoPermitido = rol switch
{
    "admin" => true,
    "instructor" => hora is >= 6 and <= 21,
    "aprendiz" => hora is >= 6 and <= 18,
    _ => false
};

Console.WriteLine(accesoPermitido ? "Acceso permitido" : "Acceso denegado");
