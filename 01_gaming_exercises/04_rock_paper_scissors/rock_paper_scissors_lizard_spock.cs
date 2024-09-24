using System;
class Template {
    static void Main() {
        Console.WriteLine("Enter your username.");
        string playerName = Console.ReadLine();

        int playerScore = 0;
        int cpuScore = 0;

        Random r = new Random();

        // Loop until either the player or the CPU reaches a score of 5
        while (playerScore < 5 && cpuScore < 5) {
            Console.WriteLine("Is your pick rock, paper, scissors, lizard, or spock?");
            string playerChoice = Console.ReadLine();

            int cpuChoice = r.Next(1, 6);  // 1 = rock, 2 = paper, 3 = scissors, 4 = lizard, 5 = spock
            Console.WriteLine(cpuChoice);  // To see what the CPU picked

            if (playerChoice == "rock" && cpuChoice == 3) {
                Console.WriteLine("You beat the CPU! It picked scissors.");
                playerScore++;
            }
            else if (playerChoice == "rock" && cpuChoice == 4) {
                Console.WriteLine("You beat the CPU! It picked lizard.");
                playerScore++;
            }
            else if (playerChoice == "lizard" && cpuChoice == 1) {
                Console.WriteLine("You lost the round! CPU chose rock");
                cpuScore++;
            }
            else if (playerChoice == "paper" && cpuChoice == 1) {
                Console.WriteLine("You beat the CPU! It picked rock.");
                playerScore++;
            }
            else if (playerChoice == "spock" && cpuChoice == 2) {
                Console.WriteLine("You lost the round! CPU chose paper.");
                cpuScore++;
            }
            else if (playerChoice == "paper" && cpuChoice == 5) {
                Console.WriteLine("You beat the CPU! It picked spock.");
                playerScore++;
            }
            else if (playerChoice == "scissors" && cpuChoice == 2) {
                Console.WriteLine("You beat the CPU! It picked paper!");
                playerScore++;
            }
            else if (playerChoice == "scissors" && cpuChoice == 4) {
                Console.WriteLine("You beat the CPU! It picked lizard!");
                playerScore++;
            }
            else if (playerChoice == "scissors" && cpuChoice == 1) {
                Console.WriteLine("You lost the round! CPU chose rock!");
                cpuScore++;
            }
            else if (playerChoice == "rock" && cpuChoice == 2) {
                Console.WriteLine("You lost the round! CPU chose paper!");
                cpuScore++;
            }
            else if (playerChoice == "paper" && cpuChoice == 3) {
                Console.WriteLine("You lost the round! CPU chose scissors!");
                cpuScore++;
            }
            else if (playerChoice == "lizard" && cpuChoice == 2) {
                Console.WriteLine("You beat the CPU! CPU chose paper!");
                playerScore++;
            }
            else if (playerChoice == "lizard" && cpuChoice == 5) {
                Console.WriteLine("You beat the CPU! CPU chose spock!");
                playerScore++;
            }
            else if (playerChoice == "spock" && cpuChoice == 3) {
                Console.WriteLine("You beat the CPU! CPU chose scissors");
                playerScore++;
            }
            else if (playerChoice == "spock" && cpuChoice == 1) {
                Console.WriteLine("You beat the CPU! CPU chose paper!");
                playerScore++;
            }

            else if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
            {
                Console.WriteLine("You must choose rock, paper or scisscors!");
            }
            else {
                Console.WriteLine("You picked the same choice as CPU!");
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
