using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Vehicle
    {
        public string nameName;
        public  string Model { get; set; } = "Default";
        public string Make { get; set; } = "Default";
        public string Year { get; set; } = "Default";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("I am driving my Vehicle.");
        }
    }
}
