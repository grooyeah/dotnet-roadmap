using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.OOP.Inheritance
{
    public class Car : Vehicle
    {
        public int Doors { get; set; }

        public Car(string brand, int speed, int doors) : base(brand, speed)
        {
            Doors = doors;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {Brand} car with {Doors} doors is driving at {Speed} km/h.");
        }
    }
}
