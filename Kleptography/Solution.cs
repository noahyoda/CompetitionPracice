using System;

namespace Kleptography
{
    class solution
    {
        static void Main(string[] args)
        {
            string firstline = Console.ReadLine();
            string key = Console.ReadLine();
            string message = Console.ReadLine();

            int n = Convert.ToInt32(firstline.Split()[0]);
            int m = Convert.ToInt32(firstline.Split()[1]);

            string alp = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
            string[] ls = alp.Split();
            string result = key;
            
            for (int i = 0; message.Length - 1 - i >= 0; i++)
            {
                char r = result[result.Length - 1 - i];
                char c = message[message.Length - 1 - i];
                int offset = Array.IndexOf(ls, r.ToString());
                int cOffset = offset;
                int iOffset = 0;

                //find offset of column
                while (ls[cOffset] != c.ToString())
                {
                    cOffset++;
                    iOffset++;
                    if (cOffset > 25)
                        cOffset -= 26;
                }

                string next = ls[iOffset];
                result = next + result;
            }
            result = result.Substring(n);
            Console.WriteLine(result);
        }
    }
}
