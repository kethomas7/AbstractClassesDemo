using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle-DONE
             * The vehicle class shall have three string properties: Year, Make, and Model-Done
             * Set the defaults of the properties to something generic in the Vehicle class- Done
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.-DONE
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.-DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle-Done
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle-done
             * Provide the implementations for the abstract methods-Done
             * Only in the Motorcycle class will you override the virtual drive method- done
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicles>();


            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing-- which means be specific not using var keyword) but use constuctors from derived classes
             */
            // 

            var carOne = new Car()
            {
                Year = "2019",
                Make = "Nissan",
                Model = "Altima",
                HasTrunk = true
            };
            
            var motorcycleOne = new Motorcycle()
            {
                Year = "2020",
                Make = "Honda",
                Model = "CB750",
                HasSideCart = false
            };
            Vehicles carTwo = new Car()
            {
                Year = "2011",
                Make = "Honda",
                Model = "Civic",
                HasTrunk = true

            };
            Vehicles motorcylceTwo = new Motorcycle()
            {
                Year = "2017",
                Make = "Yamaha",
                Model = "MT-09",
                HasSideCart = true
            };

            vehicles.Add(carOne);
            vehicles.Add(carTwo);
            vehicles.Add(motorcycleOne);
            vehicles.Add(motorcylceTwo);
            // *Set the properties values with object initializer syntax-Done


            /*
             * Add the 4 vehicles to the list-Done
             * Using a foreach loop iterate through the list and display each of the properties
             */
            foreach(Vehicles item in vehicles)
            {
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}");
            }
            // Call each of the drive methods for one car and one motorcycle
            carOne.DriveAbstract();
            carOne.DriveVirtual();

            motorcycleOne.DriveVirtual();
            motorcycleOne.DriveAbstract();

            #endregion
            Console.ReadLine();
        }
    }
}
