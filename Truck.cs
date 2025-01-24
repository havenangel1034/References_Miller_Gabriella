using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Miller_Gabriella
{
    internal class Truck : IAutomobile
    {
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        public double Weight { get; }

        public Truck(double speed, double weight, string licenseNum)
        {
            Speed = speed;
            Weight = weight;
            LicensePlate = licenseNum;

            if(Weight < 400)
            {
                Wheels = 8;
            } else
            {
                Wheels = 12;
            }
        }

        public void Stringify()
        {
             Console.WriteLine($"The Truck is travelling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}!");
        }

        public void IncreaseSpeed()
        {

            Speed += 5;

        }
        public void DecreaseSpeed()
        {

            Speed -= 5;

        }
    }
}
