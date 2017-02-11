using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//a.Write a C# program to perform a selection sort of an array of integers. In a selection
//sort, we find the smallest element of the array and interchange it with the first
//element.We repeat this process, finding the smallest element of the remaining elements
//and exchanging it with the first of the remaining elements. At each repetition
//the number of elements remaining decreases by one, until the whole array is sorted.

//b.Add timing statements to the code of part a to estimate the growth rate of the selection
//sort algorithm (see Example 7.10).

namespace Exercise7_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[100];
            Random rand = new Random();

            //fill array with 100 random numbers
            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = rand.Next(0, 100);
            }

            Console.WriteLine("Array before sorting");
            Console.WriteLine("--------------------");
            printArray(testArray);

            //create timing for sort method
            int starttime = System.Environment.TickCount;
            selectionSort(testArray);
            int stoptime = System.Environment.TickCount;

            Console.WriteLine("Array after sorting");
            Console.WriteLine("--------------------");
            printArray(testArray);

            Console.WriteLine("The time to sort the array, in milliseconds, is {0}", stoptime - starttime);

        }

        public static void selectionSort(int[] array)
        {
            int minPosition, temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                minPosition = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minPosition])
                    {
                        minPosition = j;
                    }
                }

                if (minPosition != i)
                {
                    temp = array[i];
                    array[i] = array[minPosition];
                    array[minPosition] = temp;
                }
            }
        }

        public static void printArray(int [] array)
        {
            Console.Write("Array: ");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.Write("\n");
        }
    }
}
