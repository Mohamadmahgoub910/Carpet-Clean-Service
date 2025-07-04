using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCleanService3July2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rate = 0.15;
            Console.WriteLine($"Tax Rate: {rate:P}");

            int population = 1000000;
            Console.WriteLine($"Population: {population:N0}");


             double priceSmallRoom = 25.0;
             double priceLargeRoom = 35.0;
             double taxRate = 0.06;
             int estimateValidDays = 30;

            Console.Write("Enter number of small carpets: ");
            int numSmall = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of large carpets: ");
            int numLarge = Convert.ToInt32(Console.ReadLine());

            double cost = (numSmall * priceSmallRoom) + (numLarge * priceLargeRoom);
            double tax = cost * taxRate;
            double totalEstimate = cost + tax;


            Console.WriteLine("\n==================================");
            Console.WriteLine($"Number of small carpets: {numSmall}");
            Console.WriteLine($"Number of large carpets: {numLarge}");
            Console.WriteLine($"Price per small carpet: ${priceSmallRoom}");
            Console.WriteLine($"Price per large carpet: ${priceLargeRoom}");
            Console.WriteLine($"Cost: ${cost}");
            Console.WriteLine($"Tax: ${tax}");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Total Estimate: ${totalEstimate}");
            Console.WriteLine($"This estimate is valid for {estimateValidDays} days.");
            Console.ReadLine();
        }
    }
}
