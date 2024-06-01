using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiInterfaceInheritance
{
    internal class FlyingCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }

        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }
    }
}
