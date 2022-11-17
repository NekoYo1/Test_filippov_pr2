using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Test_filippov_pr2.Geometry;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RectangleAreaCylinderReturned()
        {
            double r = 5;
            double h = 20;
            double expected = 1400;

            Cylinder a = new Cylinder();
            double actual = a.RectangleArea(r, h);
            Assert.AreEqual(expected, Math.Round(actual));
        }
    }
}
