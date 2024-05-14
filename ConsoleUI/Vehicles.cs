using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicles
    {
        //means that it is the base tempate for other classes to inherit from

        public string Year { get; set; } = "2015";
        public string Make { get; set; } = "Lexus";
        public string Model { get; set; } = "ES350";

        public abstract void DriveAbstract(); //stubbed out method//Will have to implement in the derived class

        public virtual void DriveVirtual()
        {
            Console.WriteLine("We are driving down Virtual Street.");
        }

    }
}
