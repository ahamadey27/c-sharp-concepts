namespace CSharpConcepts
{
    public class CalcApp
    {
        public static void Calc()
        {
            bool isValid;
            char userChar;
            Console.Write("Enter first int: ");
            int intOne = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write("Enter operator (+, -, *, /): ");
                string userInput = Console.ReadLine();
                isValid = char.TryParse(userInput, out userChar) && (userChar == '+' || userChar == '-' || userChar == '*' || userChar == '/');

                if (!isValid)
                {
                    Console.WriteLine("Invalid Operator");
                }
            } while (!isValid);

            Console.WriteLine("Enter second int: ");
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
