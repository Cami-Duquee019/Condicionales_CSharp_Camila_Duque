Console.Write("Ingrese el primer número entero: ");
int primero = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el segundo número entero: ");
int segundo = int.Parse(Console.ReadLine()!);

Console.Write("Ingrese el operador (+, -, *, /): ");
string entradaOperador = Console.ReadLine() ?? string.Empty;
if (entradaOperador.Length != 1)
{
    throw new ArgumentException("Operador no soportado");
}

char operador = entradaOperador[0];
if (operador == '/' && segundo == 0)
{
    throw new DivideByZeroException("No se puede dividir entre cero");
}

int resultado = operador switch
{
    '+' => primero + segundo,
    '-' => primero - segundo,
    '*' => primero * segundo,
    '/' => primero / segundo,
    _ => throw new ArgumentException("Operador no soportado")
};

Console.WriteLine($"{primero} {operador} {segundo} = {resultado}");
