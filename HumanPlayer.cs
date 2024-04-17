namespace Guess_The_Number;

    public class HumanPlayer : Player
    {
    
        public HumanPlayer(string name) : base(name)
        {
        }
        public override void MakeGuess()
        {
            Console.WriteLine("Escribe un número entre 1 y 100:"); 
            LastGuess = Convert.ToInt32(Console.ReadLine());
            Guesses.Add(LastGuess);
        }
    }