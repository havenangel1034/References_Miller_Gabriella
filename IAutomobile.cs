using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Miller_Gabriella
{
    internal interface IAutomobile
    {
            // Property to store the speed of the automobile.
            public double Speed { get; }

            // Property to store the number of wheels of the automobile.
            public int Wheels { get; }

            // Property to store the license plate number of the automobile.
            public string LicensePlate { get; }

            // Method to display the automobile's details as a string.
            public void Stringify();
        
    }

}