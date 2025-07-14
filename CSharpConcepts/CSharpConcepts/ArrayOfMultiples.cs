namespace CSharpConcepts
{
    public class ArrayOfMultiples
    {
        //Define and initialize two ints (num, length)
        //(7, 5) => [7, 14, 21, 28, 35]
        //Create int array with size length
        //loops through and insert into array
        //print final array
        public static void ArrayMult()

        {
            int num = 7;
            int length = 5;
            int[] result = new int[length];

            //assigns into array from 0 -4 and for loop 1 through 5
            for (int i = 1; i <= result.Length; i++)
            {
                result[i - 1] = num * i;
            }

            foreach (var item in result)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
