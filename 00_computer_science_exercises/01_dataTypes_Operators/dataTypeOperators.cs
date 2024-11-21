// Data Types & Operators, Nathan Paul, v0.0
using System;
class HelloWorld {
  static void Main() {
    // This is a comment, it gets ignored
    // commeejnt

    /* 
    This is still a comment.

    */

    //DATA TYPES
    // C# is STATICALLY TYPED -- once a variable has a data type it cannot change.

    // Float - float -- decimal numbers, +/- including 0.0

    // Double - double -- decimal numbers, +/-, Including 0.0 <--- MOST COMMONLY USED DECIMAL

    // Integers -- int --whole numbers, +/-, including 0

    // VARIABLES ARE 'BUCKETS' WITH A NAME TO STORE DATA INSIDE

    // DECLARING (CREATING CARIABLES)
    // Method #1 -- Declared But Not Assign
    // dataType variableName;

    int myInteger;
    double myDouble;


    // Method #2 -- Declare AND Assign
    int myInteger2 = 1;
    double myDouble2 = -2.05D;

    // Strings -- Collection of letters, numbers, special characters.
    string myString = "This is my string.";

    // Boolean -- bool - True or False values
    bool myBool = true;
    bool fireResistance = true;
    bool hasPurpleKey= false;

    // Character -- char -- a single character.
    char myChar = 'A';
    
    // ASSIGNING VALUES AFTER DECLARATION

    myInteger = 1;
    myDouble = -2.05D;

    // PRINTING VARIABLES TO THE CONSOLE TERMINAL
    // Console.WriteLine(myInteger);
    // Console.WriteLine(myDouble);

    // PRINTING EXPRESSIONS TO THE CONSOLE TERMINAL
    // Console.WriteLine(myInteger - 25);
    // Console.WriteLine(myDouble + 2.5D);

    // PRINTING VARIABLES TO THE CONSOLE TERMINAL
    // Console.WriteLine(myInteger);
    // Console.WriteLine(myDouble);

    // OPERATORS -- ARITHMETIC
    // Addition
    int myNewInt = myInteger + myInteger2;
    double myNewDouble = myDouble + myDouble2;
    double myNewNumber = myInteger + myDouble;

    // SUBTRACTION
    myNewNumber = myDouble - myInteger;

    // DIVISION
    myNewNumber = myDouble / myInteger;

    // MULTIPLACATION
    myNewNumber = myDouble * myInteger;

    // MODULUS -- Divides, then returns the REMAINDER
    // Most commonly used to determine EVEN or ODD
    myNewNumber = myDouble % 2;

    int students = 6;
    int numSlices = 35;
    int leftOvers;

    leftOvers = numSlices % students;

    // Increcment / Decrement --Most frequently used in LOOPS
    int x = 0;
    x++; // What is x equal to now?
    // Increment ++ adds 1 to the current value and puts the new value into the bucket
    x--;
    // Decrement -- subtracts 1 from the current value and puts the new value into the bucket

    // Special Assignment Operators
    x += 1;
    x *= 1;
    x /= 1;
    x -= 1;
    x %= 1;
    // Take current value, peform the calculation, put new value into bucket

    // COMPARISON OPERATORS
    // EVALUATE THE EXPRESSION, RETURN true OR false
    int y = 5;
    int z = 3;

    // IS-EQUAL-TO == is the value on the left equal to the right?
    // Console.WriteLine(y == z);

    // GREATER THAN >
    // Console.WriteLine y >z);
    // // GREATER THAN-OR-EQUAL-TO >=
    // Console.WriteLine(y >= z);
    // // LESS THAN <
    // Console.WriteLine(y < z);
    // // LESS THAN-OR-EQUAL-TO <=
    // Console.WriteLine(y <= z);

    // LOGICAL OPERATORS
    int b = 1;
    double c = 2.0D;
    string favColor = "Blue";
    // Logical AND && -- all statements must be True
    // Console.WriteLine(b > 1 && c != 5.0D); // false because b is not > 1
    // Console.WriteLine(b == 1 && c , 10.0D); // both are true, whole expression is true
    // // If one expression most likley to be false, check for it FIRST!
    // Console.WriteLine(hasPurpleKey == true && playerLevel > 5);
    // Console.WriteLine(hasPurpleKey == true && playerlevel > 5 && hasFlameThrower == true && timeRemaining > 99);
    // Logical OR \\ -- ONE statement must be True
    // Console.WriteLine(b > 1 || c != 5.0D); // true bc c is not equal to 5.0
    // Console.WriteLine(b == 2 \\ c > 10.0D); // false bc both expressions are false
    // // Check for statement most likley to be true first!
    // Console.WriteLine(hasBlueKey == true && playerLevel > 3);

    // Logical NOT ! -- Returns the opposite value of the expression
    Console.WriteLine(b > -1); // True
    Console.WriteLine(!(b > -1)); // False

    // READING USER INPUT FROM THE CONSOLE / TERMINAL

  // Console.WriteLine("What is your player name? Type it and press ENTER\n");

  // CREATE A VARIABLE TO STORE THE DATA.
  string playerName = Console.ReadLine();
  // Console.ReadLine() ONLY RETURNS string data types.
  Console.WriteLine("What is your age? Type it and press ENTER\n");
  string age = Console.ReadLine();
  Console.WriteLine(age + age);
  // PRINT THE VARIABLE TO THE SCREEN
  // Console.WriteLine("Your player name is " + playerName);
  

  // INPUTTING NUMBERS FROM THE CONSOLE.
  Console.WriteLine("How many chicken nuggies can you eat in 5 minutes? enter an integer value and press enter\n");
  int numNuggies = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine(numNuggies + numNuggies);
# TEST 
 } 
}