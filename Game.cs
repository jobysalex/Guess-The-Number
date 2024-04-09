namespace Guess_The_Number;

public class Game
{  
    private readonly Player player;
    private readonly int randomNumber;
    
    public Game(string playerName)
        {
        Random generate = new Random();
        randomNumber = generate.Next(1, 101); 
        Console.WriteLine($"\nel numero Random es: {randomNumber}"); 
        player = new Player(playerName);
        }
    public void StartPlaying(){
    
        bool playAgain = true;

            while (playAgain)
            {
                int guesses = 0; // numeros de intentos

                // declaro el bucle para inciar la partida
                while (player.LastGuess != randomNumber)
                {
                    player.MakeGuess();
                    guesses++;
                    // agrego las condiciones de acuerdo a ellas doy pistas al usuario
                    if (player.LastGuess > randomNumber)
                    {
                        Console.WriteLine(player.LastGuess + " es demasiado Alto");
                    }
                    else if (player.LastGuess < randomNumber)
                    {
                        Console.WriteLine(player.LastGuess + " es demasiado Bajo");
                    }
                    else
                    {
                        Console.WriteLine(player.LastGuess + " es Correcto! Lo adivinaste en " + guesses + " intentos.");
                    }
                }
                    playAgain = false;
            }
    }
}