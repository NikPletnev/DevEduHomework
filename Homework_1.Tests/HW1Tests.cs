using NUnit.Framework;
using Homework_1;
using System;

namespace Homework_1.Tests
{
    public class HW1Tests
    {
        private HW_1 _hw1;
        [SetUp]
        public void Setup()
        {
            _hw1 = new HW_1();
        }

        [TestCase(3, 4, -31)]
        public void CalculateResultTest(double numberA, double numberB, double expected)
        {
            //arrange

            //act

            double actual = _hw1.CalculateResult(numberA, numberB);

            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 0, "Значения A и B должны быть разными")]
        public void CalculateResultNegativeTest(double numberA, double numberB, string expectedMessage)
        {
            //arrange


            //act, assert

            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw1.CalculateResult(numberA, numberB));
            Assert.AreEqual(expectedMessage, ex.Message);
        }

       
        [TestCase("1", "2", "2", "1")]
        [TestCase("Первая", "Вторая", "Вторая", "Первая")]


        public void SwapTest(string number_1, string number_2, string expectedNumber_1, string expectedNumber_2)
        {
            //arrange

            //act

            _hw1.Swap(ref number_1, ref number_2);

            //assert

            Assert.AreEqual(expectedNumber_1, number_1);
            Assert.AreEqual(expectedNumber_2, number_2);

        }


        [TestCase(8, 4, 2)]
        [TestCase(10, 4, 2)]
        [TestCase(5, 3, 1)]

        public void DividerTest(int number_1, int number_2, int expected)
        {
            //arrange

            //act

            double actual = _hw1.Divide(number_1, number_2);

            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestCase(8, 4, 0)]
        [TestCase(10, 4, 2)]
        [TestCase(5, 3, 2)]
        public void FindRemainderTest(int number_1, int number_2, int expected)
        {
            //arrange

            //act

            double actual = _hw1.FindRemainder(number_1, number_2);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 1, 0)]
        [TestCase(1, 2, 3, 1)]


        public void SolveLinearEquationTest(double a, double b, double c, double expected)
        {
            //arrange

            //act

            double actual = _hw1.SolveLinearEquation(a, b, c);

            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 0, 0, "Происходит деление на нуль")]
        public void SolvelinearEquationNegativeTest(double a, double b, double c, string expectedMessage)
        {
            //arrange


            //act, assert

            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw1.SolveLinearEquation(a, b, c));
            Assert.AreEqual(expectedMessage, ex.Message);

        }

        [TestCase(2, 5, 3, 6, 1, -3)]
        public void ReductionToLinearEquationTest(double x1, double y1, double x2, double y2, double expectedK, double expectedB)
        {

            //arrange

            //act

            double[] actual = _hw1.ReductionToLinearEquation(x1, y1, x2, y2);

            //assert

            Assert.AreEqual(expectedK, actual[0]);
            Assert.AreEqual(expectedB, actual[1]);

        }





    }
}