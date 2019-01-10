using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the sides of a triangle and the" +
                                "area will be calculated");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            string c = Console.ReadLine();
            double sideA = double.Parse(a);
            double sideB = double.Parse(b);
            double sideC = double.Parse(c);
            double p = (sideA + sideB + sideC) / 2;
            double negativex = (-sideB + Math.Sqrt(Math.Pow(sideB, 2) - 4 * sideA * sideC)) / (2 * sideA);
            double positivex = (-sideB - Math.Sqrt(Math.Pow(sideB, 2) - 4 * sideA * sideC)) / (2 * sideA);

            Console.WriteLine("X1 is: " + negativex);
            Console.WriteLine("X2 is: " + positivex);

            Console.ReadLine();

        }
    }
}
