using System;
class Template {
    static void Main() {
        Console.WriteLine("Enter your username.");
        string playerName = Console.ReadLine();

        int playerScore = 0;
        int cpuScore = 0;

        // Loop until either the player or the CPU reaches a score of 5
        while (playerScore < 5 && cpuScore < 5) {
            Console.WriteLine("Is your pick rock, paper, or scissors?");
            string playerChoice = Console.ReadLine();



            if (playerChoice == "scissors") {
                Console.WriteLine("You lost the round! CPU chose rock!");
                cpuScore++;
            }
            else if (playerChoice == "rock") {
                Console.WriteLine("You lost the round! CPU chose paper!");
                cpuScore++;
            }
            else if (playerChoice == "paper") {
                Console.WriteLine("You lost the round! CPU chose scissors!");
                cpuScore++;
            }
            else if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
            {
                Console.WriteLine("You must choose rock, paper or scisscors!");
            }
            
            // Show the current scores
            Console.WriteLine($"Player Score: {playerScore} - CPU Score: {cpuScore}");
        }

        // End the game when someone reaches 5 points
        if (cpuScore == 5) {
            Console.WriteLine("You lost to the CPU, you really suck.");
        }
        else if (playerScore == 5) {
            Console.WriteLine("You beat the CPU, Good Job!");
        }
    }
}
