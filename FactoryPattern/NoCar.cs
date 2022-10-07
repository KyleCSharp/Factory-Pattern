using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class NoCar : IVehicle
    {
        public void Drive()
        {
           
            Console.Error.WriteLine("Error no car can be created");
        }
    }
}
