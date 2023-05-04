using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Model { get; set; } = "Generic Make";
        public int Year { get; set; } = 2011;
        public string Make { get; set; } = "Generic Model";
        public bool HasTrunk { get; internal set; }

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is in drive.");
        }

    }
}
