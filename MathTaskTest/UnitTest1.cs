using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Test_filippov_pr2;

namespace MathTaskTest
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void RectangleArea_3and5_15returned()
        {
            int a = 3;
            int b = 5;
            int expected = 15;

            Geometry g = new Geometry();
            int actual = g.RectangleArea_3and5_15returned(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
