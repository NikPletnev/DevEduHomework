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
        [TestCase(5, 9, -26.5)]

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


        public void SwapTest(string numberA, string numberB, string expectedNumberA, string expectedNumberB)
        {
            //arrange

            //act

            _hw1.Swap(ref numberA, ref numberB);

            //assert

            Assert.AreEqual(expectedNumberA, numberA);
            Assert.AreEqual(expectedNumberB, numberB);

        }


        [TestCase(8, 4, 2)]
        [TestCase(10, 4, 2)]
        [TestCase(5, 3, 1)]

        public void DividerTest(int numberA, int numberB, int expected)
        {
            //arrange

            //act

            double actual = _hw1.Divide(numberA, numberB);

            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestCase(8, 4, 0)]
        [TestCase(10, 4, 2)]
        [TestCase(5, 3, 2)]
        public void FindRemainderTest(int numberA, int numberB, int expected)
        {
            //arrange

            //act

            double actual = _hw1.FindRemainder(numberA, numberB);

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
        [TestCase(1, 3, 1, 6, 0, 1)]
        [TestCase(1, 2, 3, 2, 0, 2)]


        public void ReductionToLinearEquationTest(double x1, double y1, double x2, double y2, double expectedK, double expectedB)
        {

            //arrange

            //act

            double[] actual = _hw1.GetLinearEquation(x1, y1, x2, y2);

            //assert

            Assert.AreEqual(expectedK, actual[0]);
            Assert.AreEqual(expectedB, actual[1]);

        }





    }
}