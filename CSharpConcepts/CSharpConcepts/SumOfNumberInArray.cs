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

            int arraySum;




        }
    }
}
