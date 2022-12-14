const string Fallo = $"Ohhhh que pena campeón, no era ese, te quedan";
Console.WriteLine("¡Buenos días!");
Console.WriteLine("Bienvenido al juego de adivinar el número. En este juego, elegiremos al azar un número del 1 al 15 y tú tendrás que adivinarlo en 3 intentos.");
Console.WriteLine("¿Todo entendido? ¡Vamos allá!");
var generadorAleatorio = new Random();
int numeroParaAdivinar = generadorAleatorio.Next(1, 3);
Console.WriteLine("Elige tu primer número.");
int intentos = 3;
string numeroElegido1 = Console.ReadLine();
int enteroElegido1 = Int32.Parse(numeroElegido1);
while (intentos > 0)
{
    if (enteroElegido1 == numeroParaAdivinar)
    {
        Console.WriteLine($"¡MUY BIEN CAMPEÓN! LO HAS ADIVINADO, EFECTIVAMENTE ERA {numeroParaAdivinar}");
        intentos = -1;
        return;
    }
    else if (enteroElegido1 > numeroParaAdivinar)
    {
        intentos = intentos - 1;
        Console.WriteLine(Fallo + $" {intentos} intentos más");
        Console.WriteLine("Solo puedo decirte que te has quedado por encima, ¿Cuál es tu siguiente número?");
        numeroElegido1 = Console.ReadLine();
        enteroElegido1 = Int32.Parse(numeroElegido1);
    }
    else if (enteroElegido1 < numeroParaAdivinar)
    {
        intentos = intentos - 1;
        Console.WriteLine(Fallo + $" {intentos} intentos más.");
        Console.WriteLine("Solo puedo decirte que te has quedado por debajo, ¿Cuál es tu siguiente número?");
        numeroElegido1 = Console.ReadLine();
        enteroElegido1 = Int32.Parse(numeroElegido1);
    }
}
Console.WriteLine("Has fallado tus 3 intentos, que pena.");
Console.WriteLine($"El número a adivinar era el {numeroParaAdivinar}");
