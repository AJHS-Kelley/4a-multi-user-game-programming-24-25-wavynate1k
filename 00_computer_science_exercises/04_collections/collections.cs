using System;
class Template{
    static void Main() {

   














      




    //   Print Array Contents -- All Elements on Single Line
    //   Console.WriteLine();  
    //   Console.WriteLine();  
    //   Console.WriteLine();  
      











      // Accessing Elements in the array with the index.  
      Console.WriteLine("The first element in breakFastFoods is: " + breakFastFoods[0]);  
      // PRINT THE 2nd ELEMENT OF THE testScores array
      // PRINT THE 3rd ELEMENT OF THE GPA array.  

      // Shortcut to Access Last Item in a Array
      Console.WriteLine("The last element of breakFastFoods is: " + breakFastFoods[breakFastFoods.Length - 1]); 
      Console.WriteLine("The last element of testScores is: " + testScores[testScores.Length - 1]);

      // CHANGING ELEMENTS IN THE ARRAY
      breakFastFoods[2] = "Green Eggs and Ham";
      testScores[0] = -1;
      GPA[1] = 4.0D;
      Console.WriteLine("The elements of each array are:\n");  
      Console.WriteLine("breakFastFoods; \n" + String.Join(",", breakFastFoods));  
      Console.WriteLine(); // Print an empty line to the screen 


      // COMMON ERRORS WITH ARRAYS
      Console.WriteLine(breakFastFoods[99]); // Index Out of Bounds -- Accessing index that does not exist in the array.

      // testScores[0] = "99"; // Error Message "Cannot implicitley convert dataType to dataType"

    } // DO NOT DELETE EVER, SHOULD BE 3 SPACES FROM LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN