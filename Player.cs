namespace Guess_The_Number;

public abstract class Player
{
      public string Name { get; private set; }
      public int LastGuess;
      public List<int> Guesses;
        protected Player(string name)
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
}