using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class Lists
    {
        //Best if size of list is unknown and good for modifying
        public static void ListBasic()
        {
            List<int> listNumbers = new List<int>(); //how to add{ 1, 2, 4, 5 };
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter a number {i + 1}: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);

            }

        }
        

    }
}
