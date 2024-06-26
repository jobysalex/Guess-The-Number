namespace Guess_The_Number;

public class Game
{  
       private readonly HumanPlayer _humanPlayer;
        private readonly AIPlayer _aiPlayer;
        private int _secretNumber;
        private int _humanGuesses;
        private int _aiGuesses;
        public Game(HumanPlayer humanPlayer, AIPlayer aiPlayer)
        {
            _humanPlayer = humanPlayer;
            _aiPlayer = aiPlayer;
            InitializeGame();
        }
        
    public void StartPlaying()
    {
    
        bool playAgain = true;

                  while (playAgain)
                {
                    _humanGuesses = 0;
                    _aiGuesses = 0;
                    _humanPlayer.ResetLastGuess();
                    _aiPlayer.ResetLastGuess();
                    // Primer intento de la IA
                    _aiGuesses++;
                    _aiPlayer.MakeGuess();
                    Console.WriteLine($"AIplayer juega el {_aiPlayer.GetLastGuess()}.");
                    if (_aiPlayer.GetLastGuess() > _secretNumber)
                    {
                        Console.WriteLine($"{_aiPlayer.GetLastGuess()} es muy alto");
                    }
                    else if (_aiPlayer.GetLastGuess() < _secretNumber)
                    {
                        Console.WriteLine($"{_aiPlayer.GetLastGuess()} es muy Bajo");
                    }
        
                    while (_humanPlayer.GetLastGuess() != _secretNumber && _aiPlayer.GetLastGuess() != _secretNumber)
                    {
                        _humanGuesses++;
                        _humanPlayer.MakeGuess();
                        if (_humanPlayer.GetLastGuess() > _secretNumber)
                        {
                            Console.WriteLine(_humanPlayer.GetLastGuess() + " es demasiado Alto");
                        }
                        else if (_humanPlayer.GetLastGuess() < _secretNumber)
                        {
                            Console.WriteLine(_humanPlayer.GetLastGuess() + " es demasiado Bajo");
                        }
                        if (_humanPlayer.GetLastGuess() == _secretNumber)
                            break;
                        _aiGuesses++;
                        _aiPlayer.MakeGuess();
                        if (_aiPlayer.GetLastGuess() > _secretNumber)
                        {
                            Console.WriteLine(_aiPlayer.GetLastGuess() + " es demasiado alto");
                        }
                        else if (_aiPlayer.GetLastGuess() < _secretNumber)
                        {
                            Console.WriteLine(_aiPlayer.GetLastGuess() + " es demasiado Bajo");
                        }
                    }
                    if (CheckGuess())
                    {
                        if (_humanPlayer.GetLastGuess() == _secretNumber)
                        {
                            Console.WriteLine(_humanPlayer.GetLastGuess() + " es Correcto! Lo adivinaste en " + _humanGuesses + " intentos.");
                        }
                        else if (_aiPlayer.GetLastGuess() == _secretNumber)
                        {
                            Console.WriteLine(_aiPlayer.GetLastGuess() + " es Correcto! Lo adivinaste en " + _aiGuesses + " intentos.");
                        }
                        break;
                    }
            }
        }
        private void InitializeGame()
        {
            RandomNumberGenerator();
        }
        private void RandomNumberGenerator()
        {
            Random random = new Random();
            _secretNumber = random.Next(1, 101);
             Console.WriteLine($"\nel numero Random es: {_secretNumber}");
        }
        private bool CheckGuess()
        {
            return _humanPlayer.GetLastGuess() == _secretNumber || _aiPlayer.GetLastGuess() == _secretNumber;
        }
    }
                    
                

            // while (playAgain)
            // {
            //     int guesses = 0; // numeros de intentos

            //     // declaro el bucle para inciar la partida
            //     while (player.LastGuess != randomNumber)
            //     {
            //         player.MakeGuess();
            //         guesses++;
            //         // agrego las condiciones de acuerdo a ellas doy pistas al usuario
            //         if (player.LastGuess > randomNumber)
            //         {
            //             Console.WriteLine(player.LastGuess + " es demasiado Alto");
            //         }
            //         else if (player.LastGuess < randomNumber)
            //         {
            //             Console.WriteLine(player.LastGuess + " es demasiado Bajo");
            //         }
            //         else
            //         {
            //             Console.WriteLine(player.LastGuess + " es Correcto! Lo adivinaste en " + guesses + " intentos.");
            //         }
            //     }
            //         playAgain = false;
            
    
