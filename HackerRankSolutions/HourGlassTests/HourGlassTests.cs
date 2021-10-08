using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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

            /* Matrix look like
             * list {1, 1, 1}
             * list {0, 1, 0}
             * list {1, 1, 1}
             */

            //first col
            matrix[0][0] = 1;   //[list 0][position 0]
            matrix[2][0] = 1;   //[list 2][ position 0]
            //second col
            matrix[0][1] = 1;
            matrix[1][1] = 1;
            matrix[2][1] = 1;
            //third col
            matrix[0][2] = 1;
            matrix[2][2] = 1;

            Assert.AreEqual(7, Hourglass.HourglassSum(matrix));

        }

        [TestMethod]
        public void TestMildMatrix()
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

            /* Matrix look like
             * list {1, 1, 1}
             * list {0, 1, 0}
             * list {1, 1, 1}
             */

            //first hourglass
            //first col
            matrix[0][0] = 1;
            matrix[2][0] = 1;
            //second col
            matrix[0][1] = 1;
            matrix[1][1] = 1;
            matrix[2][1] = 1;
            //third col
            matrix[0][2] = 1;
            matrix[2][2] = 1;

            //second glass
            //first col
            matrix[3][2] = 2;
            matrix[5][2] = 1;
            //second col
            matrix[3][3] = 4;
            matrix[4][3] = 2;
            matrix[5][3] = 2;
            //third col
            matrix[3][4] = 4;
            matrix[5][4] = 4;

            Assert.AreEqual(19, Hourglass.HourglassSum(matrix));

        }

        [TestMethod]
        public void TestMildShifted()
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

            /* Matrix look like
             * list {1, 1, 1}
             * list {0, 1, 0}
             * list {1, 1, 1}
             */

            //first hourglass
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

            //second glass
            //first col
            matrix[3][2] = 2;
            matrix[5][2] = 1;
            //second col
            matrix[3][3] = 4;
            matrix[4][3] = 2;
            matrix[5][3] = 2;
            //third col
            matrix[3][3] = 4;
            matrix[5][3] = 4;

            Assert.AreEqual(19, Hourglass.HourglassSum(matrix));

        }

    }
}
