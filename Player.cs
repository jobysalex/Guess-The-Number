namespace Guess_The_Number;

public class Player
{
      public string Name { get; private set; }
        private int LastGuess;
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

         public int GetLastGuess()
        {
            return LastGuess;
        } 

         public void ResetLastGuess()
        {
            LastGuess = 0;
        }  
    
}