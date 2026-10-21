Console.Write("Ingrese un año: ");
int anio = int.Parse(Console.ReadLine()!);

bool esBisiesto = anio % 400 == 0 || (anio % 4 == 0 && anio % 100 != 0);
Console.WriteLine(esBisiesto ? "Bisiesto" : "No bisiesto");
