namespace Guess_The_Number;

public class Game
{  
    private readonly Player player;
    private int randomNumber;
    
    public Game(Player player)
        {
        this.player = player;
        InitializeGame();
        }
        
    public void StartPlaying()
    {
    
        bool playAgain = true;

            while (playAgain)
            {
                int guesses = 0; // numeros de intentos

                // declaro el bucle para inciar la partida
                while (player.GetLastGuess() != randomNumber)
                {
                    player.MakeGuess();
                    guesses++;
                    // agrego las condiciones de acuerdo a ellas doy pistas al usuario
                    if (player.GetLastGuess() > randomNumber)
                    {
                        Console.WriteLine(player.GetLastGuess() + " es demasiado Alto");
                    }
                    else if (player.GetLastGuess() < randomNumber)
                    {
                        Console.WriteLine(player.GetLastGuess() + " es demasiado Bajo");
                    }
                    else if(CheckGuess())
                    {
                        Console.WriteLine(player.GetLastGuess() + " es Correcto! Lo adivinaste en " + guesses + " intentos.");
                    }

                    
                }
                    playAgain = false;
            }
        }
        public void InitializeGame()
        {
            RandomNumberGenerator();
        }

        private void RandomNumberGenerator()
        {
        Random generate = new Random();
        randomNumber = generate.Next(1, 101); 
        Console.WriteLine($"\nel numero Random es: {randomNumber}"); 
        }

        private bool CheckGuess()
        {
            return player.GetLastGuess() == randomNumber;
        }
        
}