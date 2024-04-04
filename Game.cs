namespace Guess_The_Number;

class Game
{
    public void GenerateNumber(){
    
        int randomNumber;

        Random generate = new Random();
        randomNumber = generate.Next(1, 101); 
        Console.WriteLine($"\nel numero Random es: {randomNumber}"); 

        bool playAgain = true;

            while (playAgain)
            {
                int guess = 0; // el numero que el usuario adiviva
                int guesses = 0; // numeros de intentos

                Console.WriteLine("Escribe un número entre 1 y 100:"); 
                // declaro el bucle para inciar la partida
                while (guess != randomNumber)
                {
                    // Solicitar al usuario que ingrese su suposición
                    Console.Write("=======>  ");
                    // Lee la entrada del usuario y convertirla a un número entero
                    guess = Convert.ToInt32(Console.ReadLine());
                    // Incremento el contador de intentos
                    guesses++;
                    // agrego las condiciones de acuerdo a ellas doy pistas al usuario
                    if (guess > randomNumber)
                    {
                        Console.WriteLine(guess + " es demasiado Alto");
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine(guess + " es demasiado Bajo");
                    }
                    else
                    {
                        Console.WriteLine(guess + " es Correcto! Lo adivinaste en " + guesses + " intentos.");
                    }
                }
                    playAgain = false;
            }
    }
}