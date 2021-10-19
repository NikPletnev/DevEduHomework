using NUnit.Framework;
using System;
using Homework_3;


namespace Homework_3.Tests
{
    public class HW3_Tests
    {
        private HW_3 _hw3;
        [SetUp]
        public void Setup()
        {
            _hw3 = new HW_3();
        }


        public int[] getArrayForSearchNumbersSumEvenIsGreaterSumOfOdd(int key)
        {

            switch (key)
            {
                case 1:
                    int[] testArray = new int[] { 2, 4, 6, 8 };
                    return testArray;
                    break;
                default:
                    int[] testArray_2 = new int[] { 2, 4, 6, 8, 12, 14, 16, 18 };
                    return testArray_2;
                    break;
            }
        }
        public int[] getArrayForFindAllNumbersThatAreDivisibleByANumber(int key)
        {

            switch (key)
            {
                case 1:
                    int[] testArray = new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900 };
                    return testArray;
                    break;
                default:
                    int[] testArray_2 = new int[] { 200, 400, 600, 800};
                    return testArray_2;
                    break;
            }
        }


        [TestCase(123, 387, true)]
        [TestCase(123, 456, false)]

        public void CheckSameDigitsTest(int a, int b, bool expected)
        {
            //arrange

            //act
            bool actual = _hw3.CheckSameDigits(a, b);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 1)]
        [TestCase(20, 2)]

        public void SearchNumbersSumEvenIsGreaterSumOfOdd(int number, int key)
        {
            //arrange

            //act
            int[] expected = getArrayForSearchNumbersSumEvenIsGreaterSumOfOdd(key);
            int[] actual = _hw3.SearchNumbersSumEvenIsGreaterSumOfOdd(number);
            //assert

            Assert.AreEqual(expected, actual);
        }


        [TestCase(228, 822)]
        [TestCase(1337, 7331)]

        public void ReverseNumberTest(int number, int expected)
        {
            //arrange

            //act
            int actual = _hw3.ReverseNumber(number);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(228, 0)]
        [TestCase(1337, 4)]
        public void CountOddNumbersTest(int number, int expected)
        {
            //arrange

            //act
            int actual = _hw3.CountOddNumbers(number);
            //assert

            Assert.AreEqual(expected, actual);
        }


        [TestCase(27, 3)]
        [TestCase(8, 2)]
        public void FindCubeOfNumberUsingTheHalfDivisionMethodTest(double number, double expected)
        {
            //arrange

            //act
            double actual = _hw3.FindCubeOfNumberUsingTheHalfDivisionMethod(number);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(30, 45, 15)]
        [TestCase(15, 40, 5)]

        public void CalculateGreatestCommonFactorTest(int a, int b, int expected)
        {
            //arrange

            //act
            double actual = _hw3.CalculateGreatestCommonFactor(a, b);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 3)]
        [TestCase(10, 34)]

        public void SearchFibbonachiNumberTest(int number, int expected)
        {

            //arrange

            //act
            double actual = _hw3.SearchFibbonachiNumber(number);
            //assert

            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, 15, 21)]
        [TestCase(8, 15, 14)]


        public void SumAllNumbersInRangeThatDivBySevenTest(int a, int b, int expected)
        {
            //arrange

            //act
            double actual = _hw3.SumAllNumbersInRangeThatDivBySeven(a, b);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 5)]
        [TestCase(-21, 7)]

        public void SearchMaxDividerTest(int number, int expected)
        {
            //arrange

            //act
            double actual = _hw3.SearchMaxDivider(number);
            //assert

            Assert.AreEqual(expected, actual);
        }


        [TestCase(2, 4, 16)]
        [TestCase(3, 3, 27)]
        public void PowerNumberTest(double a, double b, double expected)
        {
            //arrange

            //act
            double actual = _hw3.PowerNumber(a, b);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(100, 1)]
        [TestCase(200, 2)]
        public void FindAllNumbersThatAreDivisibleByANumberTest(int number,  int key)
        {
            //arrange

            //act
            int[] expected = getArrayForFindAllNumbersThatAreDivisibleByANumber(key);
            int[] actual = _hw3.FindAllNumbersThatAreDivisibleByANumber(number);
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 4)]
        [TestCase(20, 5)]

        public void CountNumbersWhoseSquareIsLessThanTest(int number, int expected)
        {
            //arrange

            //act
            double actual = _hw3.CountNumbersWhoseSquareIsLessThan(number);
            //assert

            Assert.AreEqual(expected, actual);
        }
    }
}