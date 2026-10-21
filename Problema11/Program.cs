Console.Write("Ingrese el estado del semáforo (rojo, amarillo o verde): ");
EstadoSemaforo estado = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant() switch
{
    "rojo" => EstadoSemaforo.Rojo,
    "amarillo" => EstadoSemaforo.Amarillo,
    "verde" => EstadoSemaforo.Verde,
    _ => throw new ArgumentException("Estado de semáforo no válido")
};

string instruccion = estado switch
{
    EstadoSemaforo.Rojo => "Deténgase",
    EstadoSemaforo.Amarillo => "Precaución, prepárese para detenerse",
    EstadoSemaforo.Verde => "Avance",
    _ => throw new ArgumentOutOfRangeException(nameof(estado))
};

Console.WriteLine(instruccion);

enum EstadoSemaforo
{
    Rojo,
    Amarillo,
    Verde
}
