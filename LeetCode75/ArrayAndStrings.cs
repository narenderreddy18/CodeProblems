using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProblems.LC75
{
    internal class ArrayAndStrings
    {
        public string MergeStringsAlternatively(string word1, string word2)
        {
            //You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1.
            //If a string is longer than the other, append the additional letters onto the end of the merged string.Return the merged string.
            
            int l1 = word1.Length;
            int l2 = word2.Length;
            int maxLength = Math.Max(l1, l2);
            var mergedString = new StringBuilder();

            for (int i = 0; i < maxLength; i++)
            {
                if (i < l1)
                {
                    mergedString.Append(word1[i]);
                }
                if (i < l2)
                {
                    mergedString.Append(word2[i]);
                }
            }

            return mergedString.ToString();
        }
        public string GcdOfStrings(string str1, string str2)
        {
            //For two strings s and t, we say "t divides s" if and only if s = t + t + t + ... + t + t(i.e., t is concatenated with itself one or more times).
            //Given two strings str1 and str2, return the largest string x such that x divides both str1 and str2.
            
            if (str1 + str2 != str2 + str1)
            {
                return "";
            }
            return str1.Substring(0, Gcd(str1.Length, str2.Length));
        }

        static int Gcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return Gcd(b, a % b);
        }
    }
}
