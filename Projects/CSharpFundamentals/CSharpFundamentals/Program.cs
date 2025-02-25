using CSharpFundamentals.Basics;
using CSharpFundamentals.OOP.Encapsulation;
using CSharpFundamentals.OOP.Inheritance;
using CSharpFundamentals.OOP.InterfacesAndPolymorphism;

// Basics

Console.WriteLine("===== C# Fundamentals Showcase =====");

Console.WriteLine("\n");

Variables.VariablesDemo();

Console.WriteLine("\n");

DataTypes.DataTypesDemo();

Console.WriteLine("\n");

ControlFlow.ControlFlowDemo();

Console.WriteLine("\n");

Loops.LoopsDemo();

Console.WriteLine("\n");

int a = 34, b = 35;

var additionResult = Methods.MethodsDemoAddition(a, b);

Console.WriteLine($"Addition result for {a} + {b} = {additionResult}");

Console.WriteLine("\n");

Exceptions.ExceptionsDemo();

// OOP

Console.WriteLine("===== OOP Showcase =====");

Person person = new("Alice", 28);

person.Introduce();

Car car = new("Tesla", 120, 4);

Bike bike = new("Yamaha", 80);

car.Drive();

bike.Drive();

List<IAnimal> animals = new() { new Dog(), new Cat() };

foreach (var animal in animals)
{
    animal.Speak();
}