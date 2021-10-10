using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ShiftTest
{
    [TestClass]
    public class ArrayShiftTest
    {
        [TestMethod]
        public void TestSimpleShift()
        {
            int[] a = { 1, 2, 3, 4 };
            List<int> test = a.ToList();

            List<int> result = ArrayShift.ArrayShift.ShiftLeft(test, 2);

            int[] e = { 3, 4, 1, 2 };
            List<int> expected = e.ToList();

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFullRotation()
        {
            int[] a = { 1, 2, 3, 4 };
            List<int> test = a.ToList();

            List<int> result = ArrayShift.ArrayShift.ShiftLeft(test, 4);

            int[] e = { 1, 2, 3, 4 };
            List<int> expected = e.ToList();

            CollectionAssert.AreEqual(expected, result);
        }

    }
}
