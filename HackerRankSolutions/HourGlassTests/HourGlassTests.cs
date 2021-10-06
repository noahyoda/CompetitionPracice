using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hourglass
{
    [TestClass]
    public class HourGlassTests
    {
        [TestMethod]
        public void TestSimpleMatrix()
        {
            List<List<int>> matrix = new List<List<int>>();
            //col
            for (int i = 0; i <= 6; i++)
            {
                matrix.Add(new List<int>());
                //row
                for (int ii = 0; ii <= 6; ii++)
                {
                    matrix[i].Add(0);
                }
            }
            //first col
            matrix[0][0] = 1;
            matrix[0][2] = 1;
            //second col
            matrix[1][0] = 1;
            matrix[1][1] = 1;
            matrix[1][2] = 1;
            //third col
            matrix[2][0] = 1;
            matrix[2][2] = 1;

            Assert.AreEqual(7, Hourglass.HourglassSum(matrix));

        }
    }
}
