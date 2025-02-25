namespace CSharpFundamentals.Basics
{
    public class Exceptions
    {
        public static void ExceptionsDemo()
        {
            try
            {
                Console.Write("Enter numerator: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Enter denominator: ");
                int denom = int.Parse(Console.ReadLine());

                int result = num / denom;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid number format. Please enter valid integers.");
            }
        }
    }
}
