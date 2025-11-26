using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Vehicle Starting.");
        }

        public virtual void StopEngine()
        {
            Console.WriteLine("Vehicle Stopping.");
        }

        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }
}
