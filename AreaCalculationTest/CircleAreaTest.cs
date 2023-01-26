﻿using ShapeAreaCalculation.Classes;
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
        public void CircleArea_PositiveRandomDoubleNumber_ReturnedCalculatedValue()
        {
            Random random = new Random();
            double randomNumber = random.NextDouble();
            Shape circle = GetShape.Circle(randomNumber);

            double cricleArea = circle.Area;

            Assert.AreEqual(Math.PI * (randomNumber * randomNumber), cricleArea);
        }

        [TestMethod]
        public void CircleArea_NegativeRandomDoubleNumber_ReturnedCalculatedValue()
        {
            Random random = new Random();
            double randomNumber = -random.NextDouble();
            Shape circle = GetShape.Circle(randomNumber);

            double cricleArea = circle.Area;

            Assert.AreEqual(Math.PI * (randomNumber * randomNumber), cricleArea);
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
            Random random = new Random();

            Int64 randomNumber = random.NextInt64();

            double firstNumber = randomNumber;
            double secondNumber = randomNumber;

            Shape circle = GetShape.Circle(randomNumber);

            var circleArea = circle.Area;

            Assert.AreEqual(Math.PI * (firstNumber * secondNumber), circleArea);
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