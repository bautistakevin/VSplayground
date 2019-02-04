using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "the cat ran uphill";
            string reversed = reverse(str);
            string temp = "";
            foreach(string s in reversed.Split(' '))
            {
                temp += reverse(s) + ' ';
            }
            Console.WriteLine(temp);
            Console.ReadLine();
        }
        private static string reverse(string str)
        {
            char[] chars = str.ToCharArray();
            int x = chars.Length - 1;
            for(int i=0; i<chars.Length/2; i++)
            {
                char temp = chars[i];
                chars[i] = chars[x];
                chars[x] = temp;
                x--;
            }
            return new string(chars);
        }
    }
}
