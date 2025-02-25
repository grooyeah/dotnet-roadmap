namespace CSharpFundamentals.Basics
{
    public class Variables
    {
        public static void VariablesDemo()
        {
            int age = 25;

            double salary = 10000.50;
            
            bool isEmployed = true;
            
            string name = "Gruia Pana";
            
            DateTime dateOfBirth = new DateTime(1999, 4, 27);

            Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary:C}, Employed: {isEmployed}, DOB: {dateOfBirth:MM/dd/yyyy}");
        }
    }
}
