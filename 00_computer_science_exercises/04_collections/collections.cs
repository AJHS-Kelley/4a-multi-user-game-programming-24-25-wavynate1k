using System;
using System.Linq;
using System.Collections;



class Template{
    static void Main() {

   














      




    //   Print Array Contents -- All Elements on Single Line
    //   Console.WriteLine();  
    //   Console.WriteLine();  
    //   Console.WriteLine();  
      











    //   // Accessing Elements in the array with the index.  
    //   Console.WriteLine("The first element in breakFastFoods is: " + breakFastFoods[0]);  
    //   // PRINT THE 2nd ELEMENT OF THE testScores array
    //   // PRINT THE 3rd ELEMENT OF THE GPA array.  

    //   // Shortcut to Access Last Item in a Array
    //   Console.WriteLine("The last element of breakFastFoods is: " + breakFastFoods[breakFastFoods.Length - 1]); 
    //   Console.WriteLine("The last element of testScores is: " + testScores[testScores.Length - 1]);

    //   // CHANGING ELEMENTS IN THE ARRAY
    //   breakFastFoods[2] = "Green Eggs and Ham";
    //   testScores[0] = -1;
    //   GPA[1] = 4.0D;
    //   Console.WriteLine("The elements of each array are:\n");  
    //   Console.WriteLine("breakFastFoods; \n" + String.Join(",", breakFastFoods));  
    //   Console.WriteLine(); // Print an empty line to the screen 


    // COMMON ERRORS WITH ARRAYS
    // Console.WriteLine(breakFastFoods[99]); // Index Out of Bounds -- Accessing index that does not exist in the array.

    // testScores[0] = "99"; // Error Message "Cannot implicitley convert dataType to dataType"
    // trying to put incorrect data type in a array

    // COMMON ARRAY METHODS -- Ways to work with the array data.
    // Sorting an Array
    int[] intArr = {-25, 50, 68, 32, 36, 100, 58, 204, -233, 777};
    string[] zooAnimals = {"elephant", "giraffe", "hippo", "leopard", "moose", "snake", "cheetah", "Rhino", "Iguana", "Falcon"};

    Array.Sort(intArr);
    Array.Sort(zooAnimals);  
    // Array.Sort will sort string arrays ALPHABETAICALLY A-Z and numerical arrays from LEAST TO GREATEST
    Console.WriteLine("The elements of each array are:\n");  
    Console.WriteLine("zooAnimals; \n" + String.Join(",", zooAnimals));  
    Console.WriteLine(); // Print an empty line to the screen

    // Finding the MIN, MAX, and SUM for numerical arrays.
    Console.WriteLine("The MINIMUM value for intArr is: " + intArr.Min()); 
    Console.WriteLine("The MAXIMUM value for intArr is: " + intArr.Max()); 
    Console.WriteLine("The SUM value for intArr is: " + intArr.Sum()); 

    } // DO NOT DELETE EVER, SHOULD BE 3 SPACES FROM LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN