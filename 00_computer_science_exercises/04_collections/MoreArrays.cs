using System;
using System.Linq;
using System.Collections;

class MoreArrays{
  static void Main() {

    string[] colors = {"blue", "red", "orange", "purple", "green"};
        // LOOPING THROUGH ARRAYS -- The old way.
        for (int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine(colors[i]);
        }

        // Looping through arrays -- the new way.
        foreach(string i in colors)
        {
            Console.WriteLine(i);
        }

        // Looping through Array Practice
        int[] numbers = {-10, 25, -345, 45, 9999, 1, 0, 68, 538, -99999};
        
        foreach(int i in numbers)
        {
            Console.WriteLine(i);
    		if (i % 2 == 0)
        {
            Console.WriteLine("This number is even");
        }
        else
        {
            Console.WriteLine("This number is odd");
        }
        
        // MULTIDIMENSIONAL ARRAYS
        // This class will only use 2 Dimensional Arrays
        int[,] nums = {{2, 4, 6}, {-1, 0, 1}};

        // ACCESSING ELEMENTS IN 2D ARRAYS
        Console.WriteLine(nums[0, 1]);
        Console.WriteLine(nums[0, 1]);

        // CHANGING ELEMENTS IN 2D ARRAYS
        nums[1, 2] = 9001;
        // CHANGE ANY ELEMENT FROM THE FIRST ARRAY
        nums[0, 2] = 502;

        // LOOPING THROUGH 2D ARRAYS
        foreach (int i in nums)
        {
            Console.WriteLine(i);
        }

        // LOOPING THROUGH 2D ARRAYS -- HARD MODE
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                Console.WriteLine(nums[i, j]);
            }
        }


    } // DO NOT DELETE EVER, SHOULD BE 3 SPACES FROM LEFT
} // DO NOT DELETE EVER, ALWAYS TOUCHING LEFT MARGIN