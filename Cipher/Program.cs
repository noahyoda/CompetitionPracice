using System;

namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            int cols = Convert.ToInt32(Console.ReadLine());
            string[] order = Console.ReadLine().Split();
            string message = Console.ReadLine();

            double temp = message.Length / cols;
            int rows = (int)Math.Round(temp, MidpointRounding.AwayFromZero);
            rows++;
            char[,] cipher = new char[rows, cols];
            int x = 0;
            int y = 0;
            //place values in matrix
            for (int i = 0; i < message.Length && y < rows; i++)
            {
                if(i < message.Length)
                    cipher[y, x] = message[i];
                else
                    cipher[y, x] = '\0';

                if (x == (cols - 1))
                {
                    x = 0;
                    y++;
                }else
                {
                    x++;
                }
                
            }
            //print values in order
            string encoded = "";
            int orderpos = 0;
            x = Convert.ToInt32(order[orderpos]) - 1;
            y = 0;
            for (int i = 0; i < order.Length; i++)
            {
                while (y < rows && cipher[y, x] != '\0')
                {
                    encoded += cipher[y, x];
                    y++;
                }
                orderpos++;
                if (orderpos >= order.Length)
                    break;
                x = Convert.ToInt32(order[orderpos]) - 1;
                y = 0;
            }

            Console.WriteLine(encoded);

        }
    }
}
