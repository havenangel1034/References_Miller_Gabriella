using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Miller_Gabriella
{
    internal class Truck : IAutomobile
    {
        // Property to store the speed of the truck.
        public double Speed { get; private set; }

        // Property to store the number of wheels, which is determined by the truck's weight.
        public int Wheels { get; private set; }

        // Property to store the truck's license plate number.
        public string LicensePlate { get; private set; }

        // Property to store the weight of the truck.
        public double Weight { get; }

        // Constructor that initializes the truck's speed, weight, and license plate number.
        public Truck(double speed, double weight, string licenseNum)
        {
            Speed = speed;  // Sets the initial speed of the truck.
            Weight = weight; // Sets the truck's weight.
            LicensePlate = licenseNum;  // Assigns the provided license plate number.

            // Determines the number of wheels based on the truck's weight.
            if (Weight < 400)
            {
                Wheels = 8;  // Lighter trucks have 8 wheels.
            }
            else
            {
                Wheels = 12; // Heavier trucks have 12 wheels.
            }
        }

        // Method to print out the truck's details in a readable format.
        public void Stringify()
        {
            Console.WriteLine($"The Truck is travelling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}!");
        }

        // Method to increase the truck's speed by 5 units.
        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        // Method to decrease the truck's speed by 5 units.
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}

