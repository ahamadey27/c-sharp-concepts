namespace CSharpConcepts
{
    public class SumOfNumberInArray
    {
        public static void SumNumArray()
        {
            Console.Write("How long would you like array to be?");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            int[] newArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter array position {i + 1}");
                newArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int arraySum = 0;//must initialize, not just declare this!

            foreach (int item in newArray)
            {
                arraySum += item;
            }

            Console.WriteLine($"The length of the array is {arrayLength} and the sum is {arraySum}");
        }
    }
}
