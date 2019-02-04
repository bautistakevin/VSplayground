using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDandLCM
{
    class Program
    {
        static int ComputeGCD(int a, int b)
        {
            int gcd = 1;
            int minVal;
            if (a < b)
                minVal = a;
            else
                minVal = b;
       
            for (int x=1; x <= minVal; x++)
            {
                
                if(a%x==0 && b%x==0)
                {
                    gcd = x;
                }
            
            }
            return gcd;
        }

        static int ComputeLCM(int a, int b)
        {
            int lcm = a * b;
            int maxVal;
            if (a < b)
                maxVal = b;
            else
                maxVal = a;

            for(int x = lcm; x >= maxVal; x--) 
            {
                if(x%a==0 && x%b==0)
                {
                    lcm = x;
                }
            }
            return lcm;
        }
        static void Main(string[] args)
        {
            int valueA, valueB, gcd, lcm;
            Console.WriteLine("Please enter the first value: ");
            valueA = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second value: ");
            valueB = int.Parse(Console.ReadLine());

            gcd = ComputeGCD(valueA, valueB);
            lcm = ComputeLCM(valueA, valueB);

            Console.WriteLine($"The GCD of {valueA} and {valueB} is {gcd}");
            Console.WriteLine($"The LCM of {valueA} and {valueB} is {lcm}");

        }
    }
}
