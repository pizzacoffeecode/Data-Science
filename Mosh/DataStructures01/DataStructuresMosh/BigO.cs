using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresMosh
{
    class BigO
    {
        // (1) This method will alway run in CONSTANT TIME so it has a RUNTIME COMPLEXITY or bigO of  O(1)
        public void log(int[] numbers)
        {
            Console.WriteLine(numbers[0]);
        }

        // (2) This method will alway run in CONSTANT TIME so it has a bigO of  O(2) .. that is 2 OPERATIONS, however 
        // in bigO we don't care about the OPERATIONS, just the INPUTS, so we simplify to    O(1)
        // Whether we have 1 or 1 million OPERATIONS our method runs in CONSTANT TIME
        public void log2(int[] numbers)
        {
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[0]);
        }

        // (3) This is where the size of the INPUT matters... if our array is length of 1 we have 1 print OPERATION...
        // if it is 1 million, that's a million OPERATIONS as the for loop iterates
        // So the cost of this operation grows LINEARLY and in direct correlation to the INPUTS
        // We write this as 0(n) ...this would be the same for any type of loop
        public void log3(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        // (4) What of we ran a console log before and after the method? We would get   O(1 + n + 1)
        // Simplified to    O(2 + n)    ...however again, in bigO we do not care about the CONSTANTS so we drop the 2...
        // The answer will be   O(n)    We drop the CONSTANT because if our array had a million inputs...2 additional 
        // operations really isn't going to make all that much difference to the cost, so   O(n)
        public void log4(int[] numbers)
        {
            Console.WriteLine(numbers[0]);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine(numbers[0]);
        }

        // (5) here the RUNTIME COMPLEXITY is   O(n + n)    or simplified    O(2n)
        // Again, we drop the 2 to make     O(n)    since this is still linear growth and the 2 is still a OPERATION not an input
        public void log5(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        // (6) What if we add another input? The string array 'names'...
        // both inputs run LINERALY so lets call the second input 'm' ...that gives us  O(n + m)
        // We still simplify to     O(n)    since the RUNTIME COMPLEXITY of the method still increases LINEARLY
        public void log6(int[] numbers, string[] names)
        {
            for (int i = 0; i < numbers.Length; i++)    // n
            {
                Console.WriteLine(numbers[i]);
            }

            for (int i = 0; i < names.Length; i++)      // m
            {
                Console.WriteLine(numbers[i]);
            }
        }

        // (7) Now what about a nested loop..the algorithm for printing out all combination of items in an array
        // The RUNTIME COMPLEXITY is    O(n * n)    or simplified       O(n ^ 2)                     <-- that's n squared
        // This algorithm runs in QUADRATIC time
        // O(n^2)   is slower than     O(n)     ...with a few inputs not much difference, but over time increase greatly

        public void log7(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)        // O(n)
            {
                for (int j = 0; j < numbers.Length; j++)    // o(n)  
                {
                    Console.WriteLine("Your result is {0} , {1}", numbers[i], numbers[j]);
                }
            }
        }

        // (9) Starting to get it?  What if we added another another nested for loop?  You got it...   O(n^3)
        public void log9(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)        // O(n)
            {
                for (int j = 0; j < numbers.Length; j++)    // o(n)  
                {
                    for (int k = 0; k < numbers.Length; k++)    // o(n)  
                    {
                        Console.WriteLine("Your result is {0} , {1}, {3}", numbers[i], numbers[j], numbers[k]);
                    }
                }
            }
        }

        // (10) Next we look at the algorithms that run in LOGARITHMIC  time    o(log n)   ...unlike 
        // LINEAR TIME that increases at a steady ready, a log plateus after a time...halfing the rate with each iteration
        // efficient than    o(n).    - Video 11:21 
        // Example : A LINEAR for-loop iterating over this array would have to check each cell [0][1][2][3][4][5][6][7][8][9]
        // Binary Search:       [0][1][2][3][4] [5] [6][7][8][9]    Is the number lesser or greater than 5? High ok it must be in [6][7][8][9]
        // [6][7][8][9]   Greater than 7?      [8][9]           |vid 13:14 - In an array the size of 1 million, it would only take 19 comparisons
        // This will be revisted in the tree section

        // (11) EXPONENTIAL growth is the oposite of logarithmic growth     O(2n)
        // Will revisit

        // (12)a. Space Complexity   -      We are only talking about space complexity we are only looking at the extra/additional space relative to the size of the input
        // Regardless of how many INPUTS the program will only allocate memory for int i    so it will take O(1) space
        public void Greet(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Hi {0}", names[i]);
            }
        }

        // (12)b.   The string[] copy below is initialized as the same size as the names array,so if names is size 1000, then so will the copy array.
        // We say the space complexity is   O(n)    the more items we have in our input the more space our mrthod will take
        public void Greet2(string[] names)
        {
            string[] copy = new string[names.Length];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Hi {0}", names[i]);
            }
        }
        // When we have more memory like with a PC, we can concentrate on making our programs runtime complexity algorithm faster, but if we are limited on memory 
        // like with mobile, the space complexity should be a consideration

    }
}
