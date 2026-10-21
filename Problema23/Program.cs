Console.Write("Ingrese su usuario: ");
string usuario = Console.ReadLine() ?? string.Empty;

if (usuario != "aprendiz")
{
    Console.WriteLine("Usuario no encontrado");
}
else
{
    Console.Write("Ingrese su contraseña: ");
    string contrasena = Console.ReadLine() ?? string.Empty;
    Console.WriteLine(contrasena == "Sena2026"
        ? "Bienvenido"
        : "Contraseña incorrecta");
}
