using CSharpFundamentals.OOP.Encapsulation;

namespace CSharpFundamentals.Advanced
{
    public class LINQExamples
    {
        public static void LINQExamplesDemo()
        {
            var people = new List<Person>
            {
                new("John", 25),
                new("Maria", 30),
                new("Julie", 28),
                new("Alex", 20),
            };

            var olderThan25 = people.Where(p => p.Age > 25).ToList();

            Console.WriteLine("People older than 25:");

            foreach (var person in olderThan25)
            {
                Console.WriteLine($"{person.Name}, Age: {person.Age}");
            }

            var sortedByAge = people.OrderBy(p => p.Age).ToList();

            Console.WriteLine("\nPeople sorted by age:");

            foreach (var person in sortedByAge)
            {
                Console.WriteLine($"{person.Name}, Age: {person.Age}");
            }
        }
    }
}
