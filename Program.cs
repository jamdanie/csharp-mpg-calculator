/////////////////////////////////////////////////////////////////////////////////
// TINFO 200 A, Winter 2026
// UWTacoma, James Daniels 
// 2026-01-08 - L-mpg - C# programming project - Mileage
// This program calculates automobile fuel efficiency (MPG) for a trip
// by accepting miles driven and gallons used, then computing MPG.
/////////////////////////////////////////////////////////////////////////////////
// Change History
// Date ------- Developer -- Description
// 2026-01-08 - jadanie  - Creation of Mileage console app
// 2026-01-08 - jadanie  - Added input/output validation and formatted MPG
// 2026-01-08 - jadanie - Corrected spelling errors in comments
/////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mileage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user interface - does two things
            // 1 - explain WHY the user should use the software
            // 2 - explain HOW the user uses the software - gives them HELP
            Console.Write(@"
********************************************************************
*************** Automobile Fuel Efficiency Calculator ***************
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
Welcome to the amazing auto efficiency fuel calculator. This app will 
accept input for the number of the miles driven in a typical automobile trip
and the number of gallons used and it will calculate the miles per 
gallon for the trip. Using this you can more effectively plan your family
vacations and budget your gasoline resources.

Let's get started. Begin by entering the number of miles driven for 
this trip as a whole number (ex: 297,300, etc.): ");

            // INPUT - get the input data values from the user
            // capture the user input as a whole number of miles
            int milesDriven = int.Parse(Console.ReadLine());

            Console.Write("Now enter the amount of fuel consumed in gallons (ex: 9.8, 12.67, etc.): ");
            double gallonsUsed = double.Parse(Console.ReadLine());

            // processing - 
            double mpg = milesDriven / gallonsUsed;

            // OUTPUT section -
            Console.WriteLine($"For the current trip, you achieved a fuel efficiency rate of: {mpg} MPG.");

            Console.WriteLine("Thanks for using the amazing Mileage Calculator!");
        }
    }
}
