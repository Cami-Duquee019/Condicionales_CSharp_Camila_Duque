using System;
Console.WriteLine("Menú de opciones:");
Console.WriteLine("1. Consultar saldo\n2. Retirar dinero\n3. Consignar dinero\n4. Salir");
Console.WriteLine("Ingrese una opción del 1 al 4: ");
int opcion = int.Parse(Console.ReadLine());
string mensaje = opcion switch
{
    1 => " Consultar saldo",
    2 => " Retirar dinero",
    3 => " Consignar dinero",
    4 => " Salir",
    _ => "Opción inválida."
};
if (opcion >= 1 && opcion <= 4)
{
    Console.WriteLine($"Usted ha seleccionado la opción {opcion}: {mensaje}");
}
else
{
    Console.WriteLine(mensaje);
}