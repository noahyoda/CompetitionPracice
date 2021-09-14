using System;
using System.Collections.Generic;

namespace SubarrayDivision
{
    class Subarray
    {
        static void Main(string[] args)
        {
            //challenge: https://www.hackerrank.com/challenges/the-birthday-bar/problem
            int m = int.Parse(Console.ReadLine());
            List<int> sq = new List<int>(Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s)));
            int[] dates = Array.ConvertAll(Console.ReadLine().Split(" "), s => int.Parse(s));

            Console.WriteLine(birthday(sq, dates[0], dates[1]));

        }

        private static int birthday(List<int> s, int d, int m)
        {
            /*
             * Given:
             * s: numbers in each square
             * d: sum we are trying to reach
             * m: length of substring
             */

            int sum = d;
            int options = 0;

            for (int i = 0; i <= s.Count - m; i++)
            {
                int curr = subSum(s.GetRange(i, m));
                if (curr == sum)
                    options++;
            }

            return options;
        }

        private static int subSum(List<int> arr)
        {
            int sum = 0;

            foreach (int x in arr)
            {
                sum += x;
            }

            return sum;
        }

    }
}
