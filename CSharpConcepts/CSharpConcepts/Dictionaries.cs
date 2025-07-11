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


            }






        }



    }
}
