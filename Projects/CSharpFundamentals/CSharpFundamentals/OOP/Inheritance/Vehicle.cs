using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.OOP.Inheritance
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vehicle(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public virtual void Drive()
        {
            Console.WriteLine($"The {Brand} is driving at {Speed} km/h.");
        }
    }
}
