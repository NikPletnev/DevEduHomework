using NUnit.Framework;
using Homework_5;
using System;

namespace Homework_5.Tests
{
    public class Hw_5Tests
    {
        private HW_5 _hw5;
        [SetUp]
        public void Setup()
        {
            _hw5 = new HW_5();
        }


        public int[,] GetTestArray(int key)
        {
            int[,] array = key switch
            {
                1 => new int[,] 
                { { 3, 2, 1 },  
                  { 4, 8, 15 }, 
                  { 12, 5, 10 } },
                2 => new int[,]
                { { -3, 1, 32 },
                  {19, 22, 4 }, 
                  {11, 85, 63 } },
                3 => new int[,]
                {{-3}},
                _ => new int[,] { },
            };
            return array;
        }

        public int[,] GetExpectedArrayForFlipDiagonallyTest(int key)
        {
            int[,] array = key switch
            {
                1 => new int[,]
                { { 3, 4, 12},
                  { 2, 8, 5 },
                  { 1, 15, 10 } },
                2 => new int[,]
                { {-3, 19, 11 },
                  {1, 22, 85 },
                  {32, 4, 63 } },
                3 => new int[,]
               {{-3}},
                _ => new int[,] { },
            };
            return array;
        }


        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)]
        [TestCase(4, 4)]

        public void FlipDiagonallyTest(int GetTestArrayKey, int GetExpectedArrayForFlipDiagonallyTestKey)
        {
            //arrange

            int[,] actual = GetTestArray(GetTestArrayKey);
            int[,] expected = GetExpectedArrayForFlipDiagonallyTest(GetExpectedArrayForFlipDiagonallyTestKey);

            //act
            _hw5.FlipDiagonally(actual);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2)]
        [TestCase(2, 2)]
        [TestCase(3, 1)]
        [TestCase(4, 0)]


        public void NumberOfElementsThatMoreThanNeighborsTest(int GetTestArrayKey, int expected)
        {
            //arrange

            int[,] actualArray = GetTestArray(GetTestArrayKey);

            //act
            int actual =  _hw5.NumberOfElementsThatMoreThanNeighbors(actualArray);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 0, 2)]
        [TestCase(2, 0, 0)]
        [TestCase(3, 0, 0)]


        public void GetIndexMinElementTest(int GetTestArrayKey, int expectedRow, int expectedColumn)
        {
            //arrange

            int[,] actualArray = GetTestArray(GetTestArrayKey);

            //act
            int[] actual = _hw5.GetIndexMinElement(actualArray);

            //assert
            Assert.AreEqual(expectedRow, actual[0]);
            Assert.AreEqual(expectedColumn, actual[1]);

        }


        [TestCase(4, "Array has no elements")]

        public void GetIndexMinElementNegativeTest(int GetTestArrayKey, string expected)
        {
            int[,] actualArray = GetTestArray(GetTestArrayKey);

            Exception ex = Assert.Throws(typeof(Exception), () => _hw5.GetIndexMinElement(actualArray));

            Assert.AreEqual(expected, ex.Message);
        }


        [TestCase(1, 1, 2)]
        [TestCase(2, 2, 1)]
        [TestCase(3, 0, 0)]


        public void GetIndexMaxElementTest(int GetTestArrayKey, int expectedRow, int expectedColumn)
        {
            //arrange

            int[,] actualArray = GetTestArray(GetTestArrayKey);

            //act
            int[] actual = _hw5.GetIndexMaxElement(actualArray);

            //assert
            Assert.AreEqual(expectedRow, actual[0]);
            Assert.AreEqual(expectedColumn, actual[1]);

        }

        [TestCase(4, "Array has no elements")]

        public void GetIndexMaxElementNegativeTest(int GetTestArrayKey, string expected)
        {
            int[,] actualArray = GetTestArray(GetTestArrayKey);

            Exception ex = Assert.Throws(typeof(Exception), () => _hw5.GetIndexMaxElement(actualArray));

            Assert.AreEqual(expected, ex.Message);
        }

        [TestCase(1, 1)]
        [TestCase(2, -3)]
        [TestCase(3, -3)]


        public void SerachMinInArrayTest(int GetTestArrayKey, int expected)
        {
            //arrange

            int[,] actualArray = GetTestArray(GetTestArrayKey);

            //act
            int actual = _hw5.SerachMinInArray(actualArray);

            //assert
            Assert.AreEqual(expected, actual);
           
        }

        [TestCase(4, "Array has no elements")]

        public void SerachMinInArrayNegativeTest(int GetTestArrayKey, string expected)
        {
            int[,] actualArray = GetTestArray(GetTestArrayKey);

            Exception ex = Assert.Throws(typeof(Exception), () => _hw5.SerachMinInArray(actualArray));

            Assert.AreEqual(expected, ex.Message);
        }


        [TestCase(1, 15)]
        [TestCase(2, 85)]
        [TestCase(3, -3)]

        public void SerachMaxInArrayTest(int GetTestArrayKey, int expected)
        {
            //arrange

            int[,] actualArray = GetTestArray(GetTestArrayKey);

            //act
            int actual = _hw5.SerachMaxInArray(actualArray);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(4, "Array has no elements")]

        public void SerachMaxInArrayNegativeTest(int GetTestArrayKey, string expected)
        {
            int[,] actualArray = GetTestArray(GetTestArrayKey);

            Exception ex = Assert.Throws(typeof(Exception), () => _hw5.SerachMaxInArray(actualArray));

            Assert.AreEqual(expected, ex.Message);
        }




    }
}