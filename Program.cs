using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Name and Location //
            string name = "Caleb Willden";
            string location = "Rexburg, Idaho";
            Console.WriteLine($"I am {name}." +
                $"I am from {location}.");

            // Today //
            // Source: https://stackoverflow.com/questions/6817266/how-to-get-the-current-date-without-the-time
            var today = DateTime.Now;
            Console.WriteLine($"Today is {today.ToLongDateString()}.");

            // Days Until Christmas //
            var christmas = new DateTime(today.Year, 12, 25);
            var daysUntilChristmas = christmas.DayOfYear - today.DayOfYear;
            Console.WriteLine($"Days until Christmas: {daysUntilChristmas}");

            // Programming Example //
            // 2.1 - C# Programming Yellow Book by Rob Miles
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Width (Meters): "); // Using Write instead of WriteLine for input. Source - https://stackoverflow.com/questions/12556279/how-to-take-user-input-in-the-same-line
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Length (Meters): ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            
            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            // Pause Terminal //
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
