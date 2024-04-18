namespace Guess_The_Number;

public abstract class Player
{
      public string Name { get; private set; }
<<<<<<< HEAD
      public int LastGuess;
      public List<int> Guesses;
        protected Player(string name)
=======
        private int LastGuess;
        public Player(string name)
>>>>>>> 7107f3bab1d4694e548ef9c4d75fb50f8a9fce34
        {
            Name = name;
            LastGuess = 0;
            Guesses = new List<int>();
        }
        public abstract void MakeGuess();
        public int GetLastGuess()
        {
            return LastGuess;
        }
        public void ResetLastGuess()
        {
            LastGuess = 0;
        }
<<<<<<< HEAD
=======

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
    
>>>>>>> 7107f3bab1d4694e548ef9c4d75fb50f8a9fce34
}