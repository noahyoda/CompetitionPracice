using System;
using System.Collections.Generic;

namespace Supermajority
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = Convert.ToInt32(Console.ReadLine());
            Dictionary<int, int> ints = new Dictionary<int, int>();
            int max = 1;
            for (int i = 0; i < lines; i++)
            {
                int curr = Convert.ToInt32(Console.ReadLine());
                if (!ints.ContainsKey(curr))
                {
                    ints.Add(curr, 1);
                } else
                {
                    ints[curr] = ints[curr] + 1;
                    if (ints[curr] > max)
                        max = ints[curr];
                }
            }

            decimal multipled = max / 2;
            multipled = multipled * 3;
            if (multipled < lines)
                Console.WriteLine("False");
            else
                Console.WriteLine("True");

        }
    }
}
