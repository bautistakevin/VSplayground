using System;

namespace AmazonInterviewQuestion
{
    class Program
    {
        //Run-length encoding is a fast and simple method for representing strings with repeating characters
        //ie: "AAAABBCCCDDDEAA" outputs "4A2B3C3D2A"
        //implement the methods required to encode/decode a string.
        
        static void Main(string[] args)
        {
            string inputString = "AAAABBBCCCDDDEAA";
            string outputString = EncodeString(inputString);
            Console.WriteLine($"the input string was {inputString}, the output string was {outputString}");

            inputString = "4A3B2C4D4A";
            outputString = DecodeString(inputString);
            Console.WriteLine($"the input string was {inputString}, the output string was {outputString}");
        }

        private static string EncodeString(string inputString)
        {
            int count = 1;
            char[] t = inputString.ToCharArray();
            string result = "";
           
            for (int i = 0; i < t.Length; i++)
            {
                if(i == t.Length-1)
                {
                    result += count.ToString() + t[i];
                }
                else if(t[i] == t[i+1])
                {
                    count++;
                }
                else
                {
                    result += count.ToString() + t[i];
                    count = 1;
                }
            }
            return result;
        }

        private static string DecodeString(string inputString)
        {
            int numTimes = 1;
            string output = "";
            for (int i = 0; i < inputString.Length; i++)
            {
                if(inputString[i]>='0' && inputString[i]<='9')
                {
                    numTimes = int.Parse(inputString[i].ToString());
                }
                else
                {
                    for (int j = 0; j < numTimes; j++)
                    {
                        output += inputString[i];
                    }                   
                }
            }
            return output;
        }
    }
}
