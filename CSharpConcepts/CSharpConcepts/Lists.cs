namespace CSharpConcepts
{
    public class Lists
    {
        //Best if size of list is unknown and good for modifying
        public static void ListBasic()
        {
            List<int> listNumbers = new List<int>(); //how to add{ 1, 2, 4, 5 };
            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Enter a number {i + 1}: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            listNumbers.RemoveRange(2, 3); //removes from index 2 through index 5
            listNumbers.RemoveAt(0);

            foreach (var item in listNumbers)
            {
                Console.Write(item);
            }

        }


    }
}
