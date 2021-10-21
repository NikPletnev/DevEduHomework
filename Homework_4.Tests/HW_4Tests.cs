using NUnit.Framework;
using System;
using Homework_4;

namespace Homework_4.Tests
{

    public class Tests
    {
        private HW_4 _hw4;
        [SetUp]
        public void Setup()
        {
            _hw4 = new HW_4();
        }


        public int[] GetTestArray(int key)
        {
            int[] array = key switch
            {
                1 => new int[] { 3, 2, 1, 4 },
                2 => new int[] { -3, 1, 32, 19, 22 },
                _ => new int[] { },
            };
            return array;
        }

        public int[] GetExpectedArrayForSort(int key)
        {
            int[] array = key switch
            {
                1 => new int[] { 1, 2, 3, 4 },
                2 => new int[] { -3, 1, 19, 22 ,32 },
                _ => new int[] { },
            };
            return array;
        }


        public int[] GetExpecetdArrayForSwapParts(int key)
        {
            int[] array = key switch
            {
                1 => new int[] { 1, 4, 3, 2 },
                2 => new int[] { 19, 22, 32, -3, 1 },
                _ => new int[] { },
            };
            return array;
        }


        [TestCase(1, 1)]
        [TestCase(2, 2)]

        public void BubbleSortTest(int keyForTestArray , int keyForExpectedArraySort)
        {
            //arrange

            int[] actual = GetTestArray(keyForTestArray);
            int[] expected = GetExpectedArrayForSort(keyForExpectedArraySort);

            //act
            _hw4.BubbleSort(actual);

            //assert
            Assert.AreEqual(expected, actual);
        }
       
        [TestCase(1, 1)]
        [TestCase(2, 2)]

        public void SelectSortTest(int keyForTestArray, int keyForExpectedArraySort)
        {
            //arrange

            int[] actual = GetTestArray(keyForTestArray);
            int[] expected = GetExpectedArrayForSort(keyForExpectedArraySort);

            //act
            _hw4.SelectSort(actual);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        public void SwapArrayPartsTest(int keyForTestArray, int keyForSwapArrayParts)
        {

            //arrange

            int[] actual = GetTestArray(keyForTestArray);
            int[] expected = GetExpecetdArrayForSwapParts(keyForSwapArrayParts);

            //act
            _hw4.SwapArrayParts(actual);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 6)]
        [TestCase(2, 20)]


        public void SumOddElementsTest(int keyForTestArray, int expected)
        {

            //arrange

            int[] actualArray = GetTestArray(keyForTestArray);

            //act
            int actual = _hw4.SumOddElements(actualArray);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2)]
        [TestCase(2, 0)]
        public void GetIndexOfMinTest(int keyForTestArray, int expected)
        {
            //arrange

            int[] actualArray = GetTestArray(keyForTestArray);

            //act
            int actual = _hw4.GetIndexOfMin(actualArray);

            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 3)]
        [TestCase(2, 2)]
        public void GetIndexOfMaxTest(int keyForTestArray, int expected)
        {
            //arrange

            int[] actualArray = GetTestArray(keyForTestArray);

            //act
            int actual = _hw4.GetIndexOfMax(actualArray);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 4)]
        [TestCase(2, 32)]
        public void GetMaxTest(int keyForTestArray, int expected)
        {
            //arrange

            int[] actualArray = GetTestArray(keyForTestArray);

            //act
            int actual = _hw4.GetMax(actualArray);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1)]
        [TestCase(2, -3)]
        public void GetMinTest(int keyForTestArray, int expected)
        {
            //arrange

            int[] actualArray = GetTestArray(keyForTestArray);

            //act
            int actual = _hw4.GetMin(actualArray);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}