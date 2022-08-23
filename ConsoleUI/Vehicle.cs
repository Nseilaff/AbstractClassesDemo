
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
   public abstract class Vehicle
    {
        public string Make;
        public string Model;
        public string Year;

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Virtual Driving");
        }
       
    }

}

