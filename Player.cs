namespace Guess_The_Number;

public class Player
{
      public string Name { get; private set; }
        public int LastGuess { get; private set; }
        public Player(string name)
        {
            Name = name;
            LastGuess = 0;
        }

        public void MakeGuess()
        {    
        Console.WriteLine("Escribe un número entre 1 y 100:"); 
        LastGuess = Convert.ToInt32(Console.ReadLine());
        }        
    
}