using System;
class GuessNumber {
    static void Main() {
      int numGuess = 0;
      int maxGuess = 7;

      // Generate the secret number here.
      Random rnd = new Random(); // Create an object named 'rnd' that isa copy of the Random() class.
      // int secretNumber = rnd.Next(100); // Generate from 0 to ?
      int secretNumber = rnd.Next(25, 1000); // Generate from ? to ?
      Console.WriteLine(secretNumber);
      
      // while loop
        // Allow the user to guess the number.
        // Compare the guess to the secret number.
        // If match, print win, if > or < give a hint.
        // +1 to numGuess
        // Check if numGuess > maxGuesse
        // If true, print a "lose game" message, if false guess again.
    }
}