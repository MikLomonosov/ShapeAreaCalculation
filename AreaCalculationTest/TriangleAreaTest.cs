using ShapeAreaCalculation.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationTest
{
    [TestClass]
    public class TriangleAreaTest
    {
        [TestMethod]
        public void EquilaterialTriangleArea_Zero_ReturnedCalculatedValue()
        {
            double side = 0;
            Shape triangle = GetShape.Triangle(side, side, side);

            double triangleArea = triangle.Area;
            double perimeter = side + side + side;

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - side) * (perimeter / 2 - side) * (perimeter / 2 - side)), triangleArea);
        }

        [TestMethod]
        public void EquilaterialTriangleArea_PositiveMaxDoubleNumber_ReturnedCalculatedValue()
        {
            double side = double.MaxValue;
            Shape triangle = GetShape.Triangle(side, side, side);

            double triangleArea = triangle.Area;    
            double perimeter = side + side + side;

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - side) * (perimeter / 2 - side) * (perimeter / 2 - side)), triangleArea);
        }

        [TestMethod]
        public void EquilaterialTriangleArea_PositiveMinDoubleNumber_ReturnedCalculatedValue()
        {
            double side = 0.1;
            Shape triangle = GetShape.Triangle(side, side, side);

            double triangleArea = triangle.Area;
            double perimeter = side + side + side;

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - side) * (perimeter / 2 - side) * (perimeter / 2 - side)), triangleArea);
        }

        [TestMethod]
        public void EquilaterialTriangleArea_NegativeMaxDoubleNumber_ReturnedCalculatedValue()
        {
            double side = -0.1;
            Shape triangle = GetShape.Triangle(side, side, side);

            double triangleArea = triangle.Area;
            double perimeter = -side + (-side) + (-side);

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - (-side)) * (perimeter / 2 - (-side)) * (perimeter / 2 - (-side))), triangleArea);
        }

        [TestMethod]
        public void EquilaterialTriangleArea_NegativeMinDoubleNumber_ReturnedCalculatedValue()
        {
            double side = double.MinValue;
            Shape triangle = GetShape.Triangle(side, side, side);

            double triangleArea = triangle.Area;
            double perimeter = -side + (-side) + (-side);

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - (-side)) * (perimeter / 2 - (-side)) * (perimeter / 2 - (-side))), triangleArea);
        }

        [TestMethod]
        public void IsoscelesTriangleArea_PositiveNumbers_ReturnedCalculatedValue()
        {
            double twoSides = 1.1;
            double thirdSide = 2.2;
            Shape triangle = GetShape.Triangle(twoSides, twoSides, thirdSide);

            var triangleArea = triangle.Area;
            double perimeter = twoSides + twoSides + thirdSide;

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - twoSides) * (perimeter / 2 - twoSides) * (perimeter / 2 - thirdSide)), triangleArea);
        }

        public void IsoscelesTriangleArea_NegativeNumbers_ReturnedCalculatedValue()
        {
            double twoSides = -1.1;
            double thirdSide = -2.2;
            Shape triangle = GetShape.Triangle(twoSides, twoSides, thirdSide);

            var triangleArea = triangle.Area;
            double perimeter = -(twoSides + twoSides + thirdSide);

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - (-twoSides)) * (perimeter / 2 - (-twoSides)) * (perimeter / 2 - (-thirdSide))), triangleArea);
        }

        [TestMethod]
        public void ScaleneTriangleArea_PositiveNumbers_ReturnedCalculatedValue()
        {
            double firstSide = 2.1;
            double secondSide = 3.4;
            double thirdSide = 5.5;
            Shape triangle = GetShape.Triangle(firstSide, secondSide, thirdSide);

            var triangleArea = triangle.Area;
            double perimeter = firstSide + secondSide + thirdSide;

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - firstSide) * (perimeter / 2 - secondSide) * (perimeter / 2 - thirdSide)), triangleArea);
        }

        public void ScaleneRightTriangleArea_PositiveNumbers_ReturnedCalculatedValue()
        {
            double firstSide = 2.2;
            double secondSide = 7.3;
            double thirdSide = 7.624303246854758;
            Shape triangle = GetShape.Triangle(firstSide, secondSide, thirdSide);

            var triangleArea = triangle.Area;
            double perimeter = firstSide + secondSide + thirdSide;

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - firstSide) * (perimeter / 2 - secondSide) * (perimeter / 2 - thirdSide)), triangleArea);
        }

        [TestMethod]
        public void ScaleneTriangleArea_NegaitveNumbers_ReturnedCalculatedValue()
        {
            double firstSide = -2.1;
            double secondSide = -3.4;
            double thirdSide = -5.5;
            Shape triangle = GetShape.Triangle(firstSide, secondSide, thirdSide);

            var triangleArea = triangle.Area;
            double perimeter = -(firstSide + secondSide + thirdSide);

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - (-firstSide)) * (perimeter / 2 - (-secondSide)) * (perimeter / 2 - (-thirdSide))), triangleArea);
        }

        public void ScaleneRightTriangleArea_NegaitveNumbers_ReturnedCalculatedValue()
        {
            double firstSide = -2.2;
            double secondSide = -7.3;
            double thirdSide = -7.624303246854758;
            Shape triangle = GetShape.Triangle(firstSide, secondSide, thirdSide);

            var triangleArea = triangle.Area;
            double perimeter = -(firstSide + secondSide + thirdSide);

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - (-firstSide)) * (perimeter / 2 - (-secondSide)) * (perimeter / 2 - (-thirdSide))), triangleArea);
        }

        [TestMethod]
        public void EquilateralTriangleArea_Char_ReturnedCalculatedValue()
        {
            Shape triangle = GetShape.Triangle('s', 's', 's');

            var triangleArea = triangle.Area;
            double perimeter = 's' + 's' + 's';

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - 's') * (perimeter / 2 - 's') * (perimeter / 2 - 's')), triangleArea);
        }

        [TestMethod]
        public void TriangleArea_Char_ReturnedCalculatedValue()
        {
            Shape triangle = GetShape.Triangle('s', 'o', 's');

            var triangleArea = triangle.Area;
            double perimeter = 's' + 'o' + 's';

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - 's') * (perimeter / 2 - 'o') * (perimeter / 2 - 's')), triangleArea);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TriangleArea_String_ReturnedFormatException()
        {
            Shape triangle = GetShape.Triangle(Convert.ToDouble("s"), Convert.ToDouble("s"), Convert.ToDouble("s"));

            var triangleArea = triangle.Area;
        }

        [TestMethod]
        public void TriangleArea_Int64_ReturnedCalculatedValue()
        {
            Int64 side = Int64.MaxValue;
            double sides = side;
            Shape triangle = GetShape.Triangle(sides, sides, sides);

            var triangleArea = triangle.Area;
            double perimeter = sides * 3;

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - sides) * (perimeter / 2 - sides) * (perimeter / 2 - sides)), triangleArea);
        }

        [TestMethod]
        public void TriangleArea_Int32_ReturnedCalculatedValue()
        { 
            Shape triangle = GetShape.Triangle(10, 10, 10);

            var triangleArea = triangle.Area;
            double perimeter = 10 * 3;

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - 10) * (perimeter / 2 - 10) * (perimeter / 2 - 10)), triangleArea);
        }
        [ExpectedException(typeof(ArgumentException))]
        [TestMethod]
        public void TriangleArea_PositiveDoubleNumbersNotForTriangle_ReturnedException()
        {
            double firstSide = 1.1;
            double secondSide = 6.7;
            double thirdSide = 8.4;
            Shape triangle = GetShape.Triangle(firstSide, secondSide, thirdSide);

            var triangleArea = triangle.Area;
            double perimeter = firstSide + secondSide + thirdSide;

            Assert.AreEqual(Math.Sqrt(perimeter / 2 * (perimeter / 2 - firstSide) * (perimeter / 2 - secondSide) * (perimeter / 2 - thirdSide)), triangleArea);
        }
    }
}
