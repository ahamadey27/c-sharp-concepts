using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class Arrays
    {
        public void Array01()
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

    }
}
