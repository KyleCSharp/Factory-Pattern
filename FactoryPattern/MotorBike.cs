using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MotorBike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("This bike can drive very fast on 2 wheels");
        }
    }
}
