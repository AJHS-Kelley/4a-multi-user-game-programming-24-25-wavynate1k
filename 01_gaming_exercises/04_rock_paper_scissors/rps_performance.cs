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
        loopReqs = Convert.ToInt32(Console.ReadLine());



        while (loopCount < loopReqs) {

            int cpuChoice = r.Next(1, 4);  // 1 = rock, 2 = paper, 3 = scissors
            int playerChoice = r.Next(1, 4);  // 1 = rock, 2 = paper, 3 = scissors
            Console.WriteLine(cpuChoice);  // To see what the CPU picked

            if (playerChoice == 1 && cpuChoice == 3) {
                Console.WriteLine("You beat the CPU! It picked scissors.");
                playerScore++;
            }
            else if (playerChoice == 2 && cpuChoice == 1) {
                Console.WriteLine("You beat the CPU! It picked rock.");
                playerScore++;
            }
            else if (playerChoice == 3 && cpuChoice == 2) {
                Console.WriteLine("You beat the CPU! It picked paper!");
                playerScore++;
            }
            else if (playerChoice == 3 && cpuChoice == 1) {
                Console.WriteLine("You lost the round! CPU chose rock!");
                cpuScore++;
            }
            else if (playerChoice == 1 && cpuChoice == 2) {
                Console.WriteLine("You lost the round! CPU chose paper!");
                cpuScore++;
            }
            else if (playerChoice == 2 && cpuChoice == 3) {
                Console.WriteLine("You lost the round! CPU chose scissors!");
                cpuScore++;
            }
            else if (playerChoice == 1 && cpuChoice == 1) { 
                Console.WriteLine("You drawed with the CPU!"); 
                numDraws++;

            }
            else if (playerChoice == 2 && cpuChoice == 2) {
                Console.WriteLine("You drawed with the CPU!"); 
                numDraws++;
            }
            else if (playerChoice == 3 && cpuChoice == 3) { 
                Console.WriteLine("You drawed with the CPU!");
                numDraws++;
            } 
            else {
                Console.WriteLine("You picked the same choice as CPU!");
            }

            loopCount++;
            
            // Show the current scores
            Console.WriteLine($"Player Score: {playerScore} - CPU Score: {cpuScore}");
        }

        if (cpuScore < playerScore){
            Console.WriteLine($"You beat the CPU, Good job!\n Player Score: {playerScore} - CPU Score: {cpuScore} - Draws: {numDraws}");
        }
        else {
            Console.WriteLine($"You lost to the CPU\n Player Score: {playerScore} - CPU Score: {cpuScore} - Draws: {numDraws}");
        }





    }
}
