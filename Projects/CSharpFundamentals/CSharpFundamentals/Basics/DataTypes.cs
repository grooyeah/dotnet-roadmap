namespace CSharpFundamentals.Basics
{
    public class DataTypes
    {
        public static void DataTypesDemo()
        {
            // Primitive Types
            int integerNumber = 100;
            double floatingPoint = 99.99;
            bool isAvailable = true;
            char letter = 'A';

            // Reference Type (String)
            string message = "Hello, C#";

            // Type Inference
            var inferredInteger = 42; // Implicitly an int
            var inferredDouble = 3.14; // Implicitly a double

            // Nullable Types
            int? nullableInt = null;
            double? nullableDouble = 55.5;

            // Type Casting & Conversion
            double castedValue = (double)integerNumber; // Explicit cast
            int parsedValue = int.Parse("123"); // Parsing string to int
            bool isParsed = int.TryParse("456", out int safeParsedValue);

            Console.WriteLine("=== Data Types Showcase ===");
            Console.WriteLine($"Integer: {integerNumber}, Double: {floatingPoint}, Bool: {isAvailable}, Char: {letter}");
            Console.WriteLine($"String: {message}, Inferred Int: {inferredInteger}, Inferred Double: {inferredDouble}");
            Console.WriteLine($"Nullable Int: {nullableInt ?? 0}, Nullable Double: {nullableDouble}");
            Console.WriteLine($"Casted Double: {castedValue}, Parsed Int: {parsedValue}, Safe Parsed Int: {safeParsedValue}, Was Parsed ? : {isParsed}");
        }
    }
}
