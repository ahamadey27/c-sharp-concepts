using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class Palindrome
    {
        public static void palindrome(string word)
        {
            char[] charWord = new char[word.Length];

            for (int i = 0 ; i < word.Length; i++)
            {
                charWord[i] = word[word.Length - 1 - i];
            }

            string reversed = new string(charWord);

            if (word == reversed.ToString())
            {
                Console.WriteLine($"{word} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{word} is not a palindrome");
            }


                

        }
    }
}
