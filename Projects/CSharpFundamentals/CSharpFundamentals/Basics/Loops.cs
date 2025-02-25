namespace CSharpFundamentals.Basics
{
    public class Loops
    {
        public static void LoopsDemo()
        {
            List<string> users = new() { "Alex", "Sandra", "Lucian", "Maria" };

            Console.WriteLine("Users: ");

            foreach (var user in users)
            {
                Console.WriteLine($"- {user}");
            }
        }
    }
}
