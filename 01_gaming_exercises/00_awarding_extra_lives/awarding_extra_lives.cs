using System;
class Template{
    static void Main() {

 int playerLives = 3;

 Console.WriteLine("What is your score?")
 string input = Console.ReadLine();
 int playerScore;

if (playerScore <= 10000)
{
    Console.WriteLine(--playerLives);
}
else if (playerScore >= 10001 && playerScore < 100000)
{
    Console.WriteLine(++playerLives);
}
else (playerScore >= 100000)
{
    playerLives += 2;
    Console.WriteLine(playerLives)
}

    }
}