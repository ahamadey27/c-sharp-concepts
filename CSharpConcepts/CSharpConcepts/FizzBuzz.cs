using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class FizzBuzz
    {
        public static void fizzBuzz()
        {
            bool Fizz = false;
            bool Buzz = false; 

            for (int i = 1; i < 100; i++)
            {
                Fizz = i % 3 == 0;
                Buzz = i % 5 == 0;
                Console.WriteLine(Fizz && Buzz ? "FizzBuzz" : Fizz ? "Fizz" : Buzz ? "Buzz" : i.ToString());
            }
        }
    }
}
