using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircumferenceandArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a radius value and the" +
                 "circumference and area of a circle will be calculated");
            string inputValue = Console.ReadLine();
            double radiusValue = double.Parse(inputValue);
            double circumference = 2.0 * Math.PI * radiusValue;
            double area = Math.PI * Math.Pow(radiusValue, 2);

            Console.WriteLine("circumference: " + circumference);
            Console.WriteLine("area: " + area);
            Console.ReadLine();
        }
    }
}
