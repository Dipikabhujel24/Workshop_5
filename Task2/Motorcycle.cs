using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Motorcycle : Vehicle
    {
        public bool HasHelmet { get; set; }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Has Helmet: " + HasHelmet);
        }

    }
}
