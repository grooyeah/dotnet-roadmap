namespace CSharpFundamentals.OOP.InterfacesAndPolymorphism
{
    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }
}
