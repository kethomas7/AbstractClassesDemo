using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicles
    {
        public bool HasTrunk;

        public override void DriveAbstract()
        {
            Console.WriteLine("We are in our car driving down Abstract Street");

        }
    }
}
