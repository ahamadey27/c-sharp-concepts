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
                Console.Write($"Enter a number {i + 1}: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            //Use foreach instead
            //for (int i = 0; i < listNumbers.Count; i++)
            //{
            //    Console.WriteLine(listNumbers[i]);

            //}

            foreach (var item in listNumbers)
            {
                Console.Write(item);
            }

        }


    }
}
