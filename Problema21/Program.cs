Console.Write("Ingrese la cantidad de artículos: ");
int cantidad = int.Parse(Console.ReadLine()!);

string mensaje = $"Tienes {cantidad} {(cantidad == 1 ? "artículo" : "artículos")} en el carrito";
Console.WriteLine(mensaje);
