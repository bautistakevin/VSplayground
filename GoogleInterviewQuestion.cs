using System;

public class GoogleInterviewQuestion
{
	static void Main(string[] args)
    {
        string s1 = "kitten";
        string s2 = "sitting";

        int editDistance = RecursiveEditDistance(s1, s1.Length - 1, s2, s2.Length - 1);
        Console.WriteLine($"The minimum edit distance is {editDistance}.");
    }

    static int RecursiveEditDistance(String s1, int s1Len, String s2, int s2Len)
    {
        int cost = 1;
        if(s1Len == 0)
        {
            return s2Len+1;
        }
        if(s2Len == 0)
        {
            return s1Len+1;
        }
        if(s1[s1Len] == s2[s2Len])
        {
            cost = 0;
        }

        return  Math.Min(1 + RecursiveEditDistance(s1, s1Len - 1, s2, s2Len),
                Math.Min(1 + RecursiveEditDistance(s1, s1Len, s2, s2Len - 1),
                cost + RecursiveEditDistance(s1, s1Len - 1, s2, s2Len - 1)));
    }
}
