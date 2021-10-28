using NUnit.Framework;
using System;
using Homework_2;

namespace Homework_2.Tests
{
    public class HW_2Tests
    {
        private HW_2 _hw2;
        [SetUp]
        public void Setup()
        {
            _hw2 = new HW_2();
        }


        private double[] GetArrayForQuadraticEquationTest(int key)
        {
            double[] arrayForTest = new double[3]; 
            switch (key)
            {
                case 2:
                    arrayForTest[0] = 2;
                    arrayForTest[1] = 3;
                    arrayForTest[2] = -1;
                    break;
                case 1:
                    arrayForTest[0] = 1;
                    arrayForTest[1] = -6;
                    break;
                default:
                    arrayForTest[0] = 0;
                    break;
            }
            return arrayForTest;
        }

        [TestCase(11, "ќдинадцать")]
        [TestCase(34, "“ридцать „етыре")]
        [TestCase(-34, "Error")]
        public void ParseIntToLiteralStringTest(int number, string expected)
        {
            //arrange

            //act

            string actual = _hw2.ParseIntToLiteralString(number);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 1)]
        [TestCase(-1, 1, 2)]
        [TestCase(1, -1, 4)]
        [TestCase(-1, -1, 3)]
        [TestCase(0, -1, 0)]
        [TestCase(-1, 0, 0)]

        public void FindTheCoordinateQuarterTest(double x, double y, double expected)
        {
            //arrange

            //act

            double actual = _hw2.FindTheCoordinateQuarter(x, y);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 1, "“очка с координатами 1,1 пренаделжит первой четверти")]
        [TestCase(-1, 1, 2, "“очка с координатами -1,1 пренаделжит второй четверти")]
        [TestCase(1, -1, 4, "“очка с координатами 1,-1 пренаделжит четвертой четверти")]
        [TestCase(-1, -1, 3, "“очка с координатами -1,-1 пренаделжит третьей четверти")]
        [TestCase(0, -1, 0, "“очка находитс€ в центре координатой оси или на координатной оси")]
        [TestCase(-1, 0, 0, "“очка находитс€ в центре координатой оси или на координатной оси")]

        public void WriteCoordinateQuarterTest(double x, double y, double quarterNumber, string expected)
        {
            //arrange

            //act

            string actual = _hw2.WriteCoordinateQuarter(quarterNumber, x , y);

            //assert

            Assert.AreEqual(expected, actual);

        }


        [TestCase(1.0, 2.0, 3.0, 1.0, 2.0, 3.0)]
        [TestCase(3.0, 2.0, 1.0, 1.0, 2.0, 3.0)]
        [TestCase(4.0, -2.0, 1.0, -2.0, 1d, 4d)]
        public void SortThreeIntNumbersTest(ref double a, ref double b, ref double c, double expectedA, double expectedB, double expectedC)
        {
            //arrange

            //act

            _hw2.SortThreeIntNumbers(ref a, ref b, ref c);

            //assert

            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
            Assert.AreEqual(expectedC, c);

        }

        [TestCase(1, -2, -3, 2 )]
        [TestCase(1, 12, 36, 1)]
        [TestCase(1, 1, 1, 0)]
        public void SolveQuadraticEquationTest(double a, double b, double c,  int key)
        {
            //arrange

            //act
            double[] expected = GetArrayForQuadraticEquationTest(key);
            double[] actual = _hw2.SolveQuadraticEquation(a, b, c);
            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestCase(2, 1, 3)]
        [TestCase(2, 2, 4)]
        [TestCase(1, 2, -1)]

        public void SolveOperationsDependingOnComparisonTest(double numberA, double numberB, double expected)
        {
            //arrange

            //act

            double actual = _hw2.SolveOperationsDependingOnComparison(numberA, numberB);
            //assert
            Assert.AreEqual(expected, actual);
        }




    }
}