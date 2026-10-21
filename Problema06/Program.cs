Console.Write("Jugada del jugador 1 (piedra, papel o tijera): ");
string jugador1 = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();

Console.Write("Jugada del jugador 2 (piedra, papel o tijera): ");
string jugador2 = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();

string resultado;
if (jugador1 == jugador2 &&
    jugador1 is "piedra" or "papel" or "tijera")
{
    resultado = "Empate";
}
else if ((jugador1 == "piedra" && jugador2 == "tijera") ||
         (jugador1 == "tijera" && jugador2 == "papel") ||
         (jugador1 == "papel" && jugador2 == "piedra"))
{
    resultado = "Gana el jugador 1";
}
else if ((jugador2 == "piedra" && jugador1 == "tijera") ||
         (jugador2 == "tijera" && jugador1 == "papel") ||
         (jugador2 == "papel" && jugador1 == "piedra"))
{
    resultado = "Gana el jugador 2";
}
else
{
    resultado = "Jugada inválida";
}

Console.WriteLine(resultado);
