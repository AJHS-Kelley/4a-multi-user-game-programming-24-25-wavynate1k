using System;
class Template{
    static void Main() {

        Console.WriteLine("Enter your username.");
        string playerName = Console.ReadLine();

        int playerScore;
        int cpuScore;
        
        string cpuChoice;
        Console.WriteLine(cpuChoice);

        Console.WriteLine("Is your pick rock, paper, or scisscors?");
        string playerChoice = Console.ReadLine();

        if (playerChoice = "rock" && cpuChoice = "scisscors")
        {
            Console.WriteLine("You beat the CPU! It picked scisscors.");
            playerScore++;
        }
        if (playerChoice = "paper" && cpuChoice = "rock") 
        {
            Console.WriteLine("You beat the CPU! It picked rock.");
            playerScore++;
        }
        if (playerChoice = "scisscors" && cpuChoice = "paper")
        {
            Console.WriteLine("You beat the CPU! It picked paper.");
            playerScore++;
        }



    }
}