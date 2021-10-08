using System;
using System.Collections.Generic;

/// <summary>
/// challenge link:
/// </summary>

namespace Hourglass
{
    public class Hourglass
    {
        public static int HourglassSum(List<List<int>> arr)
        {
            int maxSum = 0;
            int negMax = 0;
            //iterate over columns
            for(int i = 0; i < arr.Count - 3; i++)
            {
                List<int> x = arr[i];
                //iterate over positions in x column
                for(int ii = 0; ii < x.Count - 3; ii++)
                {
                    List<List<int>> square = new List<List<int>>();
                    square.Add(arr[i].GetRange(ii, 3));
                    square.Add(arr[i + 1].GetRange(ii, 3));
                    square.Add(arr[i + 2].GetRange(ii, 3));

                    Glass curr = new Glass(square);

                    //if current glass sum is the new max
                    if (curr.sum > maxSum)
                        maxSum = curr.sum;
                    //if new max is a negative
                    if (curr.sum < 0)
                        //if negMax has changed check if curr is next max, else if negMax has not changed yet change it
                        if (negMax != 0)
                            negMax = curr.sum > negMax ? curr.sum : negMax;
                        else
                            negMax = curr.sum;
                }
            }
            if (maxSum == 0)
                return negMax;
            else
                return maxSum;
        }

    }

    class Glass
    {
        private int currSum;

        public Glass(List<List<int>> g)
        {
            int s = 0;
            foreach (List<int> x in g)
            {
                foreach (int y in x)
                {
                    s += y;
                }
            }
            //subtract mids
            s -= g[0][1];
            s -= g[2][1];

            sum = s;
        }

        public int sum
        {
            get { return this.currSum; }
            protected set { this.currSum = value; }
        }

    }
}
