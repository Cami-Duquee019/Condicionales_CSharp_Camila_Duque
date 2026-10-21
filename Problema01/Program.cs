using System;
Console.WriteLine("Ingrese su edad: ");
int edad = Convert.ToInt32(Console.ReadLine());
if (edad >= 16)
{
    Console.WriteLine("Puedes votar.");
}
else
{
    Console.WriteLine("No puedes votar aún.");
}