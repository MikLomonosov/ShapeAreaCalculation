using ShapeAreaCalculation.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculationTest
{
    [TestClass]
    public class CircleAreaTest
    {
        [TestMethod]
        public void CircleArea_Zero_ReturnedZero()
        {
            double radius = 0;
            Shape circle = GetShape.Circle(radius);

            double cricleArea = circle.Area;

            Assert.AreEqual(Math.PI * (radius * radius), cricleArea);
        }

        [TestMethod]
        public void CircleArea_PositiveMinDoubleNumber_ReturnedCalculatedValue()
        {
            double radius = 0.1;
            Shape circle = GetShape.Circle(radius);

            double cricleArea = circle.Area;

            Assert.AreEqual(Math.PI * (radius * radius), cricleArea);
        }

        [TestMethod]
        public void CircleArea_PositiveMaxDoubleNumber_ReturnedCalculatedValue()
        {
            double radius = double.MaxValue;
            Shape circle = GetShape.Circle(radius);

            double cricleArea = circle.Area;

            Assert.AreEqual(Math.PI * (radius * radius), cricleArea);
        }

        [TestMethod]
        public void CircleArea_NegativeMaxDoubleNumber_ReturnedCalculatedValue()
        {
            double radius = -0.1;
            Shape circle = GetShape.Circle(radius);

            double cricleArea = circle.Area;

            Assert.AreEqual(Math.PI * (radius * radius), cricleArea);
        }

        [TestMethod]
        public void CircleArea_NegativeMinDoubleNumber_ReturnedCalculatedValue()
        {
            double radius = double.MinValue;
            Shape circle = GetShape.Circle(radius);

            double cricleArea = circle.Area;

            Assert.AreEqual(Math.PI * (radius * radius), cricleArea);
        }

        [TestMethod]
        public void CircleArea_Char_ReturnedCalculatedValue()
        { 
            Shape circle = GetShape.Circle('s');

            var circleArea = circle.Area;

            Assert.AreEqual(Math.PI * ('s' * 's'), circleArea);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void CircleArea_String_ReturnedFormatException()
        {
            Shape circle = GetShape.Circle(Convert.ToDouble("s"));

            var circleArea = circle.Area;
        }

        [TestMethod]
        public void CircleArea_Int64_ReturnedCalculatedValue()
        {
            Int64 bigRadius = Int64.MaxValue;

            double longToDouble = bigRadius;

            Shape circle = GetShape.Circle(bigRadius);

            var circleArea = circle.Area;

            Assert.AreEqual(Math.PI * (longToDouble * longToDouble), circleArea);
        }

        [TestMethod]
        public void CircleArea_Int32_ReturnedCalculatedValue()
        {
            Shape circle = GetShape.Circle(10);

            var circleArea = circle.Area;

            Assert.AreEqual(Math.PI * (10 * 10), circleArea);
        }
    }
}
