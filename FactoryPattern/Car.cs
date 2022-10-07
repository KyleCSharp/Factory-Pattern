using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle

    {
        public void Drive()
        {
            Console.WriteLine("this car can drive very fast on 4 wheels");
        }
    }
}
