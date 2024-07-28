using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeProblems.LC75
{
    internal class ArrayAndStrings
    {
        public string MergeStringsAlternatively(string word1, string word2)
        {
           
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
       public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int maxCandies = candies.Max();
            bool[] result = new bool[candies.Length];

            for (int i = 0; i < candies.Length; i++)
            {
                result[i] = (candies[i] + extraCandies) >= maxCandies;
            }
            return result;
        }

        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            int length = flowerbed.Count();

            //new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule
            for (int i = 0; i < length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    bool emptyPrev = (i == 0 || flowerbed[i - 1] == 0);
                    bool emptyNext = (i == length - 1 || flowerbed[i + 1] == 0);

                    if (emptyPrev && emptyNext)
                    {
                        flowerbed[i] = 1;
                        count++;
                        if (count >= n)
                        {
                            return true;
                        }
                    }
                }
            }
            return count >= n;
        }
    }
}
