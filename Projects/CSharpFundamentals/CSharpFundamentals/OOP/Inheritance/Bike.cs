using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.OOP.Inheritance
{
    public class Bike : Vehicle
    {
        public Bike(string brand, int speed) : base(brand, speed) { }
    }
}
