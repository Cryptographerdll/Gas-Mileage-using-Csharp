using System;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using System.Linq;

namespace GasMileage
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Drivers are concerned with the mileage their automobiles get. One driver has kept track of several tankfuls of gasoline by recording the miles driven and gallons used for each tankful. 
              Develop a C# app that will input the miles driven and gallons used (both as integers) for each tankful. 
              The app should calculate and display the miles per gallon obtained for each tankful and display the combined miles per gallon obtained for all tankfuls up to this point. 
              All averaging calculations should produce floating-point results. Display the results rounded to the nearest hundredth.
              Use the Console class’s ReadLine method and sentinel-controlled repetition to obtain the data from the user.
             */

            int MilesDriven, GallonsUsed;
            double Mileage = 0.0;
            int sumMiles = 0;
            int sumGallons = 0;
            string quit = "Y/N"; // Yes or No 
            int counter = 1;

            while (quit != "N")
            {
                Console.WriteLine("please enter miles driven by your car {0} #", counter);
                MilesDriven = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("please enter gallons you used for your trip {0} #", counter);
                GallonsUsed = Convert.ToInt32(Console.ReadLine());
                
                counter++;

                sumMiles += MilesDriven;
                sumGallons += GallonsUsed;

                Console.WriteLine("press N to stop entering values or Y to continue operation ");
                quit = Console.ReadLine();

                Mileage = Convert.ToDouble(sumMiles) / sumGallons;
                Console.WriteLine("the mileage is {0:N} mile per gallon ", Mileage);
            }
        }
    }
}
