using CodeProblems.LC75;

namespace CodeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayAndStrings arrayAndStrings = new ArrayAndStrings();

            //You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1.
            //If a string is longer than the other, append the additional letters onto the end of the merged string.Return the merged string.
            Console.WriteLine($"\nMergeStringsAlternatively: \"{arrayAndStrings.MergeStringsAlternatively("anr","svr")}\"");

            //For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t(i.e., t is concatenated with itself one or more times).
            //Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.
            Console.WriteLine($"\nGcdOfStrings: \"{arrayAndStrings.GcdOfStrings("abcabcabcabcabc", "abcabc")}\"");

            //There are n kids with candies.You are given an integer array candies, where each candies[i] represents the number of candies the ith kid has, and an integer extraCandies, denoting the number of extra candies that you have.
            //Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the extraCandies, they will have the greatest number of candies among all the kids, or false otherwise.
            //Console.WriteLine($"\nKidsWithCandies:");
            //foreach (bool value in arrayAndStrings.KidsWithCandies([2, 3, 5, 1, 3], 3))
            //{
            //    Console.WriteLine(value);
            //}

            Console.WriteLine($"\nCanPlaceFlowers: {arrayAndStrings.CanPlaceFlowers([1, 0, 0, 0, 1], 1)}");
        }
    }
}
