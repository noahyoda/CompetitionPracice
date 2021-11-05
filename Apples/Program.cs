using System;
using System.Collections.Generic;

namespace Apples
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] line = Console.ReadLine().ToCharArray();
            Dictionary<char, int> apples = new Dictionary<char, int>();
            foreach (char a in line)
            {
                if (a == 'a' || a == 'p' || a == 'l' || a == 'e')
                {
                    if (!apples.ContainsKey(a))
                        apples.Add(a, 1);
                    else
                        apples[a] = apples[a] + 1;
                }
            }
            if (apples.Count < 4)
                Console.WriteLine(0);
            else
            {
                List<int> count = new List<int>();
                if(apples['p'] > 1)
                    apples['p'] = apples['p'] / 2;
                foreach (char key in apples.Keys)
                {
                    count.Add(apples[key]);
                }
                count.Sort();
                Console.WriteLine(count[0]);
            }

        }

    }
}
