namespace CSharpConcepts
{
    public class Dictionaries
    {
        public static void dictionaryBasic()
        {
            Dictionary<int, string> dictOne = new Dictionary<int, string>()
            {
                //Add via keyvalue pairs and must be unique
                {1, "One" },
                {2, "Two" },
                {3, "Three" }
            };

            //how to cycle through elements of a list
            for (int i = 0; i < dictOne.Count; i++)
            {
                KeyValuePair<int, string> pair = dictOne.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            Console.WriteLine();

            //Foreach loop better to cycle through dictionary elements
            foreach (KeyValuePair<int, string> pair in dictOne)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }

        public static void teacherExample()
        {
            Dictionary<string, string> teachers = new Dictionary<string, string>()
            {
                {"Math", "Bill"},
                {"Science", "Same"},
            };

            //Not a good way to print value
            //Console.WriteLine(teachers["Math"]);

            if (teachers.TryGetValue("Mah", out string teacher))
            {
                Console.WriteLine(teacher);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }



    }
}
