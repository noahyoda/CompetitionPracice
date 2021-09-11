using System;
using System.Collections.Generic;

namespace SpeedCubing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] scoresTemp = Console.ReadLine().Split(" ");
            decimal toBeat = Convert.ToDecimal(Console.ReadLine());
            decimal[] scores = Array.ConvertAll(scoresTemp, s => Convert.ToDecimal(s));

            Array.Sort(scores);

            decimal upperAvg = (scores[1] + scores[2] + scores[3]) / 3;
            decimal lowerAvg = (scores[0] + scores[1] + scores[2]) / 3;

            if (Math.Round(upperAvg, 2, MidpointRounding.AwayFromZero) <= toBeat)
                Console.WriteLine("infinite");
            else if (Math.Round(lowerAvg, 2, MidpointRounding.AwayFromZero) > toBeat)
                Console.WriteLine("impossible");
            else
            {
                Console.WriteLine(Math.Round(((toBeat * 3) - scores[1] - scores[2]), 2, MidpointRounding.AwayFromZero));
            }
        }
    }
}
