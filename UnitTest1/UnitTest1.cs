using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TypeOfTriangle;

namespace UnitTest1
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void DetermineTypeOfTriangle_IsEquilateral_ReturnsEquilateral()
        {
            //var triangle = new Triangle();

            var result= TypeOfTriangle.Triangle.DetermineTypeOfTriangle(10.5,10.5,10.5);

            Assert.AreEqual(result, TypeOfTriangle.Triangle.TriangleType.Equilateral);

        }

        [TestMethod]
        public void DetermineTypeOfTriangle_IsIsosceles_ReturnsIsosceles()
        {
            var result = TypeOfTriangle.Triangle.DetermineTypeOfTriangle(12.8, 10.5, 10.5);

            Assert.AreEqual(result, TypeOfTriangle.Triangle.TriangleType.Isosceles);
        }

        [TestMethod]
        public void DetermineTypeOfTriangle_IsScalene_ReturnsScalene()
        {
            var result = TypeOfTriangle.Triangle.DetermineTypeOfTriangle(12.8, 10.5, 20.5);

            Assert.AreEqual(result, TypeOfTriangle.Triangle.TriangleType.Scalene);
        }

        [TestMethod]
        public void CheckInvalidLengths_IsZero_ReturnsFalse()
        {
            var result = TypeOfTriangle.Triangle.CheckInvalidLengths(12.8, 10.5, 0);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckInvalidLengths_IsNegative_ReturnsFalse()
        {
            var result = TypeOfTriangle.Triangle.CheckInvalidLengths(12.8, 10.5, -9);

            Assert.IsFalse(result);
        }

    }
}
