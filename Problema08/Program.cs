Console.Write("Ingrese una letra minúscula: ");
string entrada = (Console.ReadLine() ?? string.Empty).Trim();

if (entrada.Length != 1 ||
    !((entrada[0] >= 'a' && entrada[0] <= 'z') || entrada[0] == 'ñ'))
{
    Console.WriteLine("No es una letra");
}
else if ("aeiou".Contains(entrada[0]))
{
    Console.WriteLine("Es vocal");
}
else
{
    Console.WriteLine("Es consonante");
}
