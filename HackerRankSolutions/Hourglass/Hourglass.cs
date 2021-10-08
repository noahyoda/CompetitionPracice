using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// challenge link:
/// </summary>

namespace Hourglass
{
    public class Hourglass
    {
        public static int HourglassSum(List<List<int>> arr)
        {
            List<List<int>> x1 = new List<List<int>>();
            x1.Add(arr[0].GetRange(0, 3));
            x1.Add(arr[1].GetRange(0, 3));
            x1.Add(arr[2].GetRange(0, 3));

            int sum = smallSum(x1);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    List<List<int>> tempArr = new List<List<int>>();
                    tempArr.Add(arr[i].GetRange(j, 3));
                    tempArr.Add(arr[i + 1].GetRange(j, 3));
                    tempArr.Add(arr[i + 2].GetRange(j, 3));
                    int currResult = smallSum(tempArr);
                    if (currResult > sum)
                        sum = currResult;
                }
            }
            return sum;
        }

        private static int smallSum(List<List<int>> arr)
        {
            int s = 0;
            foreach (List<int> x in arr)
            {
                s += x.Sum();
            }
            s -= arr[1][0];
            s -= arr[1][2];
            return s;
        }
    }
}
