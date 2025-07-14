namespace CSharpConcepts
{
    public class TryParse
    {
        public static void TryPar()
        {
            int input;
            bool isValid;

            do
            {
                Console.Write("Enter an integer: ");
                string userInput = Console.ReadLine();
                isValid = int.TryParse(userInput, out input);

                if (!isValid)
                {
                    Console.WriteLine("This is the wrong data type");
                }
            } while (!isValid);

            Console.WriteLine($"You've typed the in {input}");



            //if (int.TryParse(Console.ReadLine(), out input))
            //{
            //    Console.WriteLine("Valid number entered: " + input);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number entered.");
            //    return;
            //}
            //Console.WriteLine("End");
        }
    }
}
