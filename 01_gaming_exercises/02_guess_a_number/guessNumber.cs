using System;
class GuessNumber {
    static void Main() {
      int numGuess = 0;
      int maxGuess = 7;
      int guess; 

      // Generate the secret number here.
      Random rnd = new Random(); // Create an object named 'rnd' that isa copy of the Random() class.
      // int secretNumber = rnd.Next(100); // Generate from 0 to ?
      int secretNumber = rnd.Next(25, 1000); // Generate from ? to ?
      Console.WriteLine(secretNumber);
      
      while (numGuess < maxGuess)
      {
          Console.WriteLine("Secret Number: " + secretNumber);
          Console.WriteLine("Please guess an integer between 25 and 1000.\n");       
          guess = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Guess" + guess);

          numGuess++;
          if (guess < secretNumber)
          {
              Console.WriteLine("Your guess is too low.\n");
          }
          else if (guess > secretNumber)
          {
            Console.WriteLine("Your guess is too high.\n")
          } 
          else
          {
            Console.WriteLine("You guessed correctley.\n")
            break;
          }

          if (numGuess >= maxGuess)
          {
              Console.WriteLine("You have lost the game.\n Your grandparents are dissapointed in you.")
          }
      }
        
        
    }
}