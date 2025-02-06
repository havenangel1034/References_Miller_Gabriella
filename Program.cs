namespace References_Miller_Gabriella
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a new Sedan object with an initial speed of 0.
            Sedan myFirstSedan = new Sedan(0);

            // Assigns the Sedan object to an IAutomobile interface reference.
            IAutomobile myAutomobile = myFirstSedan;

            // Creates another Sedan object with an initial speed of 0.
            Sedan myOtherSedan = new Sedan(0);

            // Increases the speed of myFirstSedan by 5.
            myFirstSedan.IncreaseSpeed();

            // Prints the speed of myFirstSedan (expected to be 5).
            Console.WriteLine(myFirstSedan.Speed);

            // Prints the speed of myAutomobile, which references myFirstSedan (expected to be 5).
            Console.WriteLine(myAutomobile.Speed);

            // Checks if myFirstSedan and myAutomobile refer to the same object (expected to be true).
            Console.WriteLine(myFirstSedan.Equals(myAutomobile));

            // Increases the speed of myOtherSedan by 5.
            myOtherSedan.IncreaseSpeed();

            // Prints the speed of myFirstSedan (still 5).
            Console.WriteLine(myFirstSedan.Speed);

            // Prints the speed of myOtherSedan (expected to be 5).
            Console.WriteLine(myOtherSedan.Speed);

            // Checks if myFirstSedan and myOtherSedan are considered equal (expected to be false, as they are different objects).
            Console.WriteLine(myFirstSedan.Equals(myOtherSedan));

            // Creates a new Truck object with an initial speed of 50, weight of 500, and license plate "MyTrUck".
            Truck myTruck = new Truck(50, 500, "MyTrUck");

            // Calls Stringify() method on each automobile, printing their details.
            myFirstSedan.Stringify();  // Describes myFirstSedan.
            myAutomobile.Stringify();  // Also describes myFirstSedan (since it's the same object).
            myOtherSedan.Stringify();  // Describes myOtherSedan.
            myTruck.Stringify();       // Describes myTruck.
        }
    }
}