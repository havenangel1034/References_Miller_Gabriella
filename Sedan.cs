using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Miller_Gabriella
{
    // Defines a class named 'Sedan' that implements the 'IAutomobile' interface.
    internal class Sedan : IAutomobile
    {
        // Property to store the speed of the sedan.
        public double Speed { get; private set; }

        // Property to store the number of wheels (fixed at 4 for a sedan).
        public int Wheels { get; private set; }

        // Property to store the license plate number of the sedan.
        public string LicensePlate { get; private set; }

        // Constructor that initializes the sedan's speed and sets default values for wheels and license plate.
        public Sedan(double speed)
        {
            Wheels = 4;  // A sedan typically has four wheels.
            Speed = speed;  // Sets the initial speed of the sedan.
            LicensePlate = "GCTC-06";  // Assigns a default license plate number.
        }

        // Method to print out the sedan's details in a readable format.
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at a speed of {Speed} on {Wheels}, with a license plate # of {LicensePlate}.");
        }

        // Method to increase the sedan's speed by 5 units.
        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        // Method to decrease the sedan's speed by 5 units.
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}

