namespace CSharpConcepts
{
    public class CalcApp
    {
        public static void Calc()
        {
            int intOne;
            bool isValidNumber;

            do
            {
                Console.Write("Enter first int: ");
                isValidNumber = int.TryParse(Console.ReadLine(), out intOne);

                if (!isValidNumber)
                {
                    Console.WriteLine("Invalid number. Please enter a valid integer.");
                }
            } while (!isValidNumber);

            bool isValidOperator;
            char userChar;
            do
            {
                Console.Write("Enter operator (+, -, *, /): ");
                string userInput = Console.ReadLine();
                isValidOperator = char.TryParse(userInput, out userChar) && (userChar == '+' || userChar == '-' || userChar == '*' || userChar == '/');

                if (!isValidOperator)
                {
                    Console.WriteLine("Invalid Operator");
                }
            } while (!isValidOperator);

            int intTwo;
            do
            {
                Console.Write("Enter second int: ");
                isValidNumber = int.TryParse(Console.ReadLine(), out intTwo);

                if (!isValidNumber)
                {
                    Console.WriteLine("Invalid number. Please enter a valid integer.");
                }
            } while (!isValidNumber);


            int addition = intOne + intTwo;
            int subrtract = intOne - intTwo;
            int multiply = intOne * intTwo;

            switch (userChar)
            {
                case '+': Console.WriteLine($"{intOne} + {intTwo} = {addition}"); break;
                case '-': Console.WriteLine($"{intOne} - {intTwo} = {subrtract}"); break;
                case '*': Console.WriteLine($"{intOne} * {intTwo} = {multiply}"); break;
                case '/':
                    try
                    {
                        double divide = (double)intOne / intTwo;
                        Console.WriteLine($"{intOne} / {intTwo} = {divide}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Cannot divide by zero");
                    }
                    break;
            }
        }
    }
}
