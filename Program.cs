namespace Guess_The_Number;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n        ¡Bienvenid@ al Juego Adivina el Numero!");
        Console.WriteLine("\nPor favor Escribe tu Nombre");  
        var name = Console.ReadLine();
        Console.WriteLine($"{Environment.NewLine}Hola, {name}!"); 

        Player player = new Player(name = "");
        // Llamar a Game
        Game game = new Game(player);
        game.StartPlaying();

    }
}
