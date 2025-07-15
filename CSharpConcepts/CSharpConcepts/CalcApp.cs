namespace CSharpConcepts
{
    public class CalcApp
    {
        public static void Calc()
        {
            bool isValid;
            char userChar;
            Console.WriteLine("Enter first int");
            int intOne = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("Enter operator");
                string userInput = Console.ReadLine();
                isValid = char.TryParse(userInput, out userChar);

                if (userChar == '+' || userChar == '-' || userChar == '/' || userChar == '*')
                {
                    Console.WriteLine("Enter second int");
                }
                else
                {
                    Console.WriteLine("Enter a valid integer");
                }
            } while (!isValid);

            int intTwo = Convert.ToInt32(Console.ReadLine());

            int addition = intOne + intTwo;
            int subrtract = intOne - intTwo;
            int multiply = intOne * intTwo;
            int divide = intOne / intTwo;

            switch (userChar)
            {
                case '+': Console.WriteLine($"{intOne} + {intTwo} = {addition}"); break;
                case '-': Console.WriteLine($"{intOne} - {intTwo} = {subrtract}"); break;
                case '*': Console.WriteLine($"{intOne} * {intTwo} = {multiply}"); break;
                case '/': Console.WriteLine($"{intOne} / {intTwo} = {divide}"); break;
            }


        }
    }
}
