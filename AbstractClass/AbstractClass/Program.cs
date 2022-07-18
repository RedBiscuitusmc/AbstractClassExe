using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //!Create an abstract class called Vehicle  -- Done
            //!The vehicle class shall have three string properties Year, Make, and Model -- Done
            //! Set the defaults to something generic in the Vehicle class --Done
            //!Vehicle shall have an abstract method called DriveAbstract with no implementation -- Done
            //!Vehicle shall have a virtual method called DriveVirtual with a base implementation. -- Done
            //! Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle--Done
            //!Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle--Done
            //!Provide the implementations for the abstract methods--Done
            //!Only in the Motorcycle class will you override the virtual drive method --Done
            //!Create a list of Vehicle called vehicles -- Done
            var vehicles = new List<Vehicle>();
            
         //!Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes -- Done
         //! new it up as one of each derived class--Done
         //!Set the properties with object initializer syntax--Done
                                
            Car truck = new Car();
            truck.Make = "Ford";
            truck.Model = "Ranger";
            truck.Year = "1998";

            Motorcycle MC1 = new Motorcycle();
            MC1.Make = "Harley";
            MC1.Model = "WideGlide";
            MC1.Year = "2011";
            
            Vehicle mC2 = new Motorcycle();
            mC2.Make = "Honda";
            mC2.Model = "Shadow";
            mC2.Year = "1996";

            Vehicle sUV = new Car();
            sUV.Make = "Jeep";
            sUV.Model = "Wrangler";
            sUV.Year = "2006";

         // !Add the 4 vehicles to the list --Done
            vehicles.Add(truck);
            vehicles.Add(MC1);
            vehicles.Add(mC2);
            vehicles.Add(sUV);
         //!Using a foreach loop iterate over each of the properties--Done

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make}\n Model: {vehicle.Model} \n Year: {vehicle.Year}");
            }

            //!Call each of the drive methods for one car and one motorcycle--Done
            MC1.DriveAbstract();
            //Console.ReadLine();
        }
    }
}