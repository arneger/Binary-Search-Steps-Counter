using System;
using System.Collections;

namespace BinarySearchFunction
{
    class Program
    {
        /*Binary Search Method. Takes a sorted array and a goal value and searches for the goal value in the array with binary search.
        Displays goal value, array length, steps taken to reach the goal and total steps taken if the value is found. */
        static void BinarySearcher(int[] the_array, int goal)
        {
            int first = 0;
            int last = the_array.Length -1;
            int totalIterations = 0;
            bool foundValue = false;
            ArrayList iteratedElements = new ArrayList();
            while (first <= last)
            {
                totalIterations += 1;
                int middle = (first + last) / 2;
                iteratedElements.Add(the_array[middle]); 
                if (goal == the_array[middle])
                {
                    foundValue = true;
                    break;
                }
                else if (goal > the_array[middle])
                {
                    first = middle + 1;
                }
                else
                {
                    last = middle - 1;
                }
            }
            if (foundValue)
            {
                Console.WriteLine("Goal value: " + goal);
                Console.WriteLine("Array length: " + the_array.Length);
                Console.WriteLine("\nSteps to find goal value:");
                int steps = 1;
                foreach (int element in iteratedElements)
                {
                    Console.WriteLine("Step " + steps + ": " + element);
                    ++steps;
                }
                Console.WriteLine("\nTotal amount of steps:\n" + totalIterations);
            }
            else
            {
                Console.WriteLine("Could not find " + goal + " in the array");
            }
        }

        static void Main(string[] args)
        {
            /* Add your int array to arrayValues. 
            Examples:
            int[] arrayValues = Enumerable.Range(1, 1001270).ToArray(); 
            or
            int[] arrayValues = {1,8,3,4,0} */
            int[] arrayValues = {1,7,4,20,50,66,88,30,22};
            int[] theArray = arrayValues;
            Array.Sort(theArray); //Needs to be used if your array is not sorted

            // Add your int goal value inside goal_value (The number you are looking for).
            int goalValue = 4;
            BinarySearcher(theArray, goalValue);
        }
    }
}
