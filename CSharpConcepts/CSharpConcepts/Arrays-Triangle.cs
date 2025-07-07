using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class Arrays_Triangle
    {
        public void Triangle()
        {
            Console.WriteLine("Angles of a shape to see if its a triangle");

            int[] triangleSides = new int[3];
            int triangleSum = 0;

            for (int i = 0; i < triangleSides.Length; i++)
            {
                Console.Write($"Enter angle {i + 1}: ");
                 triangleSum += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(triangleSum == 180 ? "Shape is a triangle" : "Shape is not a triangle");

        }
    }
}
