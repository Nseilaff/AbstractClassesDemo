using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        int Doors = 4;
        public override void DriveAbstract()
        {
            Console.WriteLine("This car is a ford taurus, therefore its driving is abstract.");
        }
    }
}
