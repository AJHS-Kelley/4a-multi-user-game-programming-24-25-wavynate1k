
using System;
using System.Linq;
using System.Collections;

class Template{
    static void Main() {
/*
      In C# an collecion is known as an ARRAY
      -- EACH ITEM IN THE ARRAY IS AN ELEMENT
      -- NUMBER OF ELEMENTS IN THE ARRAY CANNOT BE CHANGED
      -- CONTENTS OF EACH ELEMENT CAN CHANGE
      -- ARRAYS ARE ORDERED, MEANING EACH ITEM HAS A FIXED POSITION
      -- POSITION OF THE ELEMENT IS THE INDEX
      -- FIRST ELEMENT INDEX IS 0.
      */

      // DECLARING AND DEFINING AN ARRAY
    //   string[] breakFastFoods = {"Bacon", "Eggs", "Cold Pizza", "Capn' Crunch", "Gator Tail"};
    //   int[] testScores = {0, 25, 15, 75, 99};
    //   double[] GPA = {0.27D, 1.99D, 4.02D, 0.0D, 3.25D};      

        //   Print Array Contents -- All Elements on Single Line
        //   Console.WriteLine(The elements of each array are: \n);  
        //   Console.WriteLine(breakFastFoods: \n" + String.Join*", ", breakfastFoods));  
        //   Console.WriteLine();  
        
        /*
        // Print Array Elements on Seperate Lines 
        Console.Writeline("The elements of each array are: \n)
        Console.Writeline("breakFastFoods: \n" + String.Join*", ", breakfastFoods));
        Console.WriteLine(:)
        
    
        










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
*/


        // ArrayList --> Basically an array you can add/remove elements from.
        /* var exampleArrList = new ArrayList(); // Create an new ArrayList.
        // Adding elements to an ArrayList use .Add()
        // .Add puts the item at the end of the list
        exampleArrList.Add(5);
        exampleArrList.Add("Shrek 5: The Search for Donkey");
        exampleArrList.Add(false);
        exampleArrList.Add(1.25D);

        // Create ArrayList with Values
        var exampleArrList2 new ArrayList()
                {
                    -10, "Paul", "Blue", true, 25.25D, 196000, 0.0D
                };

        Console.WriteLine(exampleArrList[2]);
        Console.WriteLine(exampleArrList2[5]);   
            */
        // Inserting to a specific position in the ArrayList
        // Use .Insert(index, value)
        // exampleArrList.Insert(3, "Ogres are like onions. \n");
        // exampleArrList.Insert(0, -99);

        // . Remove (value) removes the FIRST OCCURENCE of the item from the ArrayList.
        /* var newList = new ArrayList()
            {
                -10, 10, 15, -25, -10, -25, 33, -25, 40
            };
            Console.WriteLine(newList[0]);
            newList.Remove(-10);
            Console.WriteLine(newList[0]);     
        

            */
        } // DO NOT DELETE EVER, SHOULD BE 3 SPACES FROM LEFT
    } // DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN