using System;
class RPS {
    static void Main() {

        int playerScore = 0;
        int cpuScore = 0;
        int numDraws = 0;

        Random r = new Random();

        // Testing Game Loop
        int loopCount = 0;
        int loopReqs = 0; // Req / Reqs is universal abbrv. or REQUEST / REQUESTS
        Console.WriteLine("How many loops do you need?\nType an INTEGER and press ENTER.\n");
        loopReqs = Convert.ToInt32(Console.Readline());



        while (playerScore < 5 && cpuScore < 5) {
            Console.WriteLine("Is your pick rock, paper, or scissors?");
            string playerChoice = Console.ReadLine();

            int cpuChoice = r.Next(1, 4);  // 1 = rock, 2 = paper, 3 = scissors
            Console.WriteLine(cpuChoice);  // To see what the CPU picked

            if (playerChoice == "rock" && cpuChoice == 3) {
                Console.WriteLine("You beat the CPU! It picked scissors.");
                playerScore++;
            }
            else if (playerChoice == "paper" && cpuChoice == 1) {
                Console.WriteLine("You beat the CPU! It picked rock.");
                playerScore++;
            }
            else if (playerChoice == "scissors" && cpuChoice == 2) {
                Console.WriteLine("You beat the CPU! It picked paper!");
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
            else {
                Console.WriteLine("You picked the same choice as CPU!");
            }

            // Show the current scores
            Console.WriteLine($"Player Score: {playerScore} - CPU Score: {cpuScore}");
        }

    }
}
