using System;
using System.Collections.Generic;

namespace ArrayShift
{
    public class ArrayShift
    {

        public static List<int> ShiftLeft(List<int> arr, int p)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                int pos = i + p;
                if (pos >= arr.Count)
                    pos = pos - arr.Count;
                result.Add(arr[pos]);
            }

            return result;
        }
        
    }
}
