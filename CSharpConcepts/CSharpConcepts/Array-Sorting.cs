using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class Array_Sorting
    {
        public static void ArraySorting()
        {
            int[] numbers = new int[] { 1, 5, 3, 7, 9, 0, 5, 34, 2 };
            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num}, ");
            }
        }

        

    }
}
