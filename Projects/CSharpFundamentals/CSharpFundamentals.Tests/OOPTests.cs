using CSharpFundamentals.OOP.Inheritance;
using CSharpFundamentals.OOP.InterfacesAndPolymorphism;


namespace CSharpFundamentals.Tests
{
    public class OOPTests
    {
        [Fact]
        public void Car_ShouldDriveWithCorrectMessage()
        {
            Car car = new("Tesla", 120, 4);
            var output = new System.IO.StringWriter();
            Console.SetOut(output);

            car.Drive();

            Assert.Contains("The Tesla car with 4 doors is driving at 120 km/h.", output.ToString());
        }

        [Fact]
        public void Dog_ShouldSpeakCorrectly()
        {
            Dog dog = new();
            var output = new System.IO.StringWriter();
            Console.SetOut(output);

            dog.Speak();

            Assert.Contains("Woof! Woof!", output.ToString());
        }
    }
}
