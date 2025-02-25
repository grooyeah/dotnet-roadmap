namespace CSharpFundamentals.OOP.InterfacesAndPolymorphism
{
    public class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
}
