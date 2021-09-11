using System;
using System.Collections.Generic;

namespace SpeedCubing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] scoresTemp = Console.ReadLine().Split(" ");
            double toBeat = Convert.ToDouble(Console.ReadLine());
            double[] scores = Array.ConvertAll(scoresTemp, s => Convert.ToDouble(s));

            Array.Sort(scores);

            double upperAvg = (scores[1] + scores[2] + scores[3]) / 3;
            double lowerAvg = (scores[0] + scores[1] + scores[2]) / 3;

            if (upperAvg < toBeat)
                Console.WriteLine("infinite");
            else if (lowerAvg > toBeat)
                Console.WriteLine("impossible");
            else
            {
                Console.WriteLine(Math.Round(((toBeat * 3) - scores[1] - scores[2]), 2));
            }
        }
    }
}
