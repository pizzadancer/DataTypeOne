using System;

namespace MoreNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            string input;
            double milesDriven;
            double gasConsumed;
            double milesPerGallon;

            Console.WriteLine(">>>Gas Mileage Calculator<<<");

            // Get milesDriven from User
            Console.WriteLine("Please enter how far you drove (in miles). ");
            input = Console.ReadLine();
            milesDriven = double.Parse(input);

            // Get gasConsumed from User
            Console.WriteLine("Please enter how much gas you used (in gallons). ");
            input = Console.ReadLine();
            gasConsumed = double.Parse(input);

            // Calculate milesPerGallon
            Console.WriteLine("Great. Calculating milesPerGallon. Hit ENTER to continue.");
            Console.ReadLine();

            milesPerGallon = milesDriven / gasConsumed;
            Console.WriteLine("The total miles-per-gallon you had for your drive: " + milesPerGallon + " miles-per-gallon.");
            Console.WriteLine("\nMiles-per-gallon Calculated. \nGoodbye.");
            Console.ReadLine();




        }
    }
}
