using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        int NumOfCylinders;
        public override void DriveAbstract()
        {
            Console.WriteLine("This is a Motorcycle.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("This bike is driving virtually.");
        }
    }
}
