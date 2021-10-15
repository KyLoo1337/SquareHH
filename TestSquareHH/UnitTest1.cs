using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SquareHH.Tests
{
    [TestClass]
    public class SquareHHTests
    {
        [TestMethod]
        public void TestTriangularSquare_2and3and4_2dot9047375096555625returned()
        {
            double[] sides = new double[]{2, 3, 4};
            double expected = 2.9047375096555625;

            var fig = new Figure(sides);
            double actual = fig.Square();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTriangularSquare_3and4and5_2dot9047375096555625returned()
        {
            double[] sides = new double[] { 3, 4, 5 };
            double expected = 6;

            var fig = new Figure(sides);
            double actual = fig.Square();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTriangularIsRectangular_3and4and5_trueReturned()
        {
            double[] sides = new double[] { 3, 4, 5 };
            bool expected = true;

            var fig = new Figure(sides);
            bool actual = fig.IsRectangular();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTriangularIsRectangular_2and3and4_falseReturned()
        {
            double[] sides = new double[] { 2, 3, 4 };
            bool expected = false;

            var fig = new Figure(sides);
            bool actual = fig.IsRectangular();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCircle_1_3dot141592653589793returned()
        {
            double expected = 3.141592653589793;

            var fig = new Figure(1);
            double actual = fig.Square();

            Assert.AreEqual(expected, actual);
        }
    }
}
