using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinConverter
{
    class CharacterCounter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a statement and I will count how many" +
                "spaces there are: ");
            string inputString = Console.ReadLine();
            Console.WriteLine("Thank you. I will now count the spaces in the " +
                "statement provided.");
            char searchCharacter = ' ';
            int numOccurences = CountCharacterOccurences(inputString, searchCharacter);
            Console.WriteLine($"the {searchCharacter} character is found {numOccurences} times.");
        }
        
        static int CountCharacterOccurences(string inputString, char searchCharacter)
        {
            int numOccurences = 0;
            
            foreach(char c in inputString)
            {
                if (c == searchCharacter)
                    numOccurences++;
            }

            return numOccurences;
        }
    }

}
