using System;

namespace Inflation
{
    class Solution
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            double[] cans = Array.ConvertAll(Console.ReadLine().Split(), s => Convert.ToDouble(s));
            Array.Sort(cans);
            double min = cans[0] / 1;
            bool imp = false;
            
            for(int i = 0; i < cans.Length; i++)
            {
                double value = cans[i] / (i + 1);
                min = value < min ? value : min;
                if (value > 1)
                    imp = true;
                    
            }
            if (imp)
                Console.WriteLine("impossible");
            else
                Console.WriteLine(min);

        }
    }
}
