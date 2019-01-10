using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemisphereVolume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a radius value and the volume of a hemisphere will be calculated");
            string inputValue = Console.ReadLine();

            double radiusValue = double.Parse(inputValue);
            double Volume = (4.0 / 3.0 * Math.PI * Math.Pow(radiusValue, 3)) / 2.0;

            Console.WriteLine("volume: " + Volume);
            Console.ReadLine();
        }
    }
}