using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            string input;
            double length;
            double height;
            double area;    // length * width

            // Get Length from User
            Console.WriteLine(">>>Area Calculator<<<");
            Console.WriteLine("Please enter the length of the rectangle. ");
            input = Console.ReadLine();
            length = double.Parse(input);

            // Get Height from User
            Console.WriteLine("Please enter the height of the rectangle. ");
            input = Console.ReadLine();
            height = double.Parse(input);

            // Calculate Area
            Console.WriteLine("Great. Calculating Area. Hit ENTER to continue.");
            Console.ReadLine();
            area = length * height;
            Console.WriteLine("The total area for your rectangle is: " + area);
            Console.WriteLine("\nArea calculated. Goodbye.");
            Console.ReadLine();
        }
    }
}
