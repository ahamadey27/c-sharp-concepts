using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class Arrays
    {
        public static void Array01()
        {
            Console.Write("enter numbers that will go in an array");

            int[] arrayIn = new int[5]; 

            for (int i = 0; i < arrayIn.Length; i++)
            {
                Console.Write($"Enter array number {i + 1}: ");
                arrayIn[i] = Convert.ToInt32(Console.ReadLine()); 
            }

            for (int i = 0; i < arrayIn.Length; i++)
            {
                Console.WriteLine($"Index {i + 1} is {arrayIn[i]}");
            }
        }

        public static void ClearArray()
        {
            int[] numbers = new int[] { 1, 7, 6, 2, 8, 3 };
            Array.Clear(numbers, 0, numbers.Length);

            foreach (var item in numbers)
            {
                Console.Write($"{item}");
            }
        }

        public static void IndexOf()
        {
            int[] numbers = new int[] { 1, 7, 6, 2, 8, 3 };
            Console.WriteLine("Enter number to search");
            int search = Convert.ToInt32(Console.ReadLine());

            int position = Array.IndexOf(numbers, search, 2); //last argument is where search starts...if fourth argument added third is start search and 4th is end search of index

            if (position >= 0)
            {
                Console.WriteLine($"Number {search} has been found at position {position}");
            }
            else
            {
                Console.WriteLine("Number search has not been found");
            }

        }

    }
}
