using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Motorcycle : Vehicle
    {
        public static bool HasSideCart { get; set; } = false;


        public override void DriveAbstract()
        {
            Console.WriteLine("This Motorcycle is a Motorcycle.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("I am driving my MotorCycle, it is a MotorCycle.");
        }

    }
}
