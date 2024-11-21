using System;
class FlowControlStructures {
  static void Main() {
    // These blocks of code are used to control how thhe program executes.
    // Basically, these block of code allow for decisions to be made

    int age = 44;
    double cheeseBurgers = 1.25D;
    string favFlavor = "Butterscotch";
    bool afraidSnakes = false;

    // Can I vote?
    if (age >= 18) // (age >= 18) is the CONDITIONAL STATEMENT
    {
        Console.WriteLine("You can vote!\n");
    }
    else if (age >= 16) // Check this next if Line #13 is false.
    {
        Console.WriteLine("You can't vote but you CAN register\n");
    }
    else
    {
        Console.WriteLine("You are not old enough to vote or register smh.\n");
    }

    /*
    You can have a single if statement by itself.
    If you have an else you MUST also have an if.
    You can have as many else if statements as needed.
    FOR NOW, USE THE else CONDITION TO PRINT ERROR MESSAGES / LOGS
    */ 

    int age = 5;
    if (age >= 0)
    {
        Console.WriteLine("Age data stored. \n");
    }
    else
    {
        Console.WriteLine("No age value deteted. Please review\n");
    }

   
























    }
}