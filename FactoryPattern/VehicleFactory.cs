using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int WheelCount)
        {
            switch(WheelCount)
            {
                case 2:
                    return new MotorBike();
                case 4:
                    return new Car();
                    case 0:
                    return new NoCar();
                default:
                    return new NoCar();

            }
        }

    }
}
