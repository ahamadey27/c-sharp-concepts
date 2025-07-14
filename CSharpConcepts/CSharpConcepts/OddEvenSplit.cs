namespace CSharpConcepts
{
    //Create two lists with int data type, for odd and even
    //Loop from 0 -20
    //add respective numbers to lists and print
    public class OddEvenSplit
    {
        public static void OddEven()
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0) //checks for even number
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }

            Console.WriteLine("Even Numbers: ");
            //printing even numbers
            foreach (var item in even)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine("\nOdd Numbers: ");
            //printing odd numbers
            foreach (var item in odd)
            {
                Console.Write($"{item}, ");
            }
        }





    }
}
