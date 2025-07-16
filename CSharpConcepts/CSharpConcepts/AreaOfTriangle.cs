namespace CSharpConcepts
{
    //Ask user for width and height, store them
    //create function to calculate area using (width + height) / 2
    //Call in main and print area of triangle
    public class AreaOfTriangle
    {

        public static void AreaTri()
        {
            bool isValid;
            int width;
            int height;

            do
            {
                Console.WriteLine("Enter width of triangle");
                isValid = int.TryParse(Console.ReadLine(), out width);

                if (!isValid)
                {
                    Console.WriteLine("Enter a valid integer.");
                }
            } while (!isValid);

            do
            {
                Console.WriteLine("Enter width of height");
                isValid = int.TryParse(Console.ReadLine(), out height);

                if (!isValid)
                {
                    Console.WriteLine("Enter a valid integer.");
                }
            } while (!isValid);

            decimal areaTriangle = (width + height) / 2;

            Console.Write($"The area of this triangle is {areaTriangle}");
        }

    }
}
