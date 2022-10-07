using System.Transactions;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine("enter the number of wheels you want for your new vehicle");
            
                input = int.TryParse(Console.ReadLine(), out wheelCount);

            }while (input== false);

            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
            


        }
    }
}