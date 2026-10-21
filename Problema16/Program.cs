using System.Globalization;

Console.Write("Ingrese la coordenada X: ");
double x = double.Parse(Console.ReadLine()!, CultureInfo.CurrentCulture);

Console.Write("Ingrese la coordenada Y: ");
double y = double.Parse(Console.ReadLine()!, CultureInfo.CurrentCulture);

string ubicacion = (x, y) switch
{
    (0, 0) => "Origen",
    (0, _) or (_, 0) => "Sobre un eje",
    (> 0, > 0) => "Primer cuadrante",
    (< 0, > 0) => "Segundo cuadrante",
    (< 0, < 0) => "Tercer cuadrante",
    _ => "Cuarto cuadrante"
};

Console.WriteLine(ubicacion);
