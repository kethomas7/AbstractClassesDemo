using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicles
    {
        public bool HasSideCart;

        public override void DriveAbstract()
        {
            Console.WriteLine("We are in our motorcycle driving down Abstract Street");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("We are driving our motorcycle down Virtual Street");
        }
    }
}
