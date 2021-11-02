using System;
using HelpersList;
using Homework_1;

namespace Homework_4
{
    public class HW_4
    {
        HW_1 hw_1 = new HW_1();
        public void SolveTask_4_1()
        {
            Helpers helpers = new Helpers();
            int arrayLenght = helpers.GetIntNumberFromUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int min = GetMin(array);
            Console.WriteLine($"\nМинимальное число в массиве: {min}");
        }

        public void SolveTask_4_2()
        {
            Helpers helpers = new Helpers();
            int arrayLenght = helpers.GetIntNumberFromUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int max = GetMax(array);
            Console.WriteLine($"\nМаксимальноле число в массиве: {max}");
        }


        public void SolveTask_4_3()
        {
            Helpers helpers = new Helpers();
            int arrayLenght = helpers.GetIntNumberFromUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int minIndex = GetIndexOfMin(array);
            Console.WriteLine($"Индекс минимального числа в массиве: {minIndex}");
        }

        public void SolveTask_4_4()
        {
            Helpers helpers = new Helpers();
            int arrayLenght = helpers.GetIntNumberFromUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int maxIndex = GetIndexOfMax(array);
            Console.WriteLine($"Индекс максимального числа в массиве: {maxIndex}");
        }

        public void SolveTask_4_5()
        {
            Helpers helpers = new Helpers();
            int arrayLenght = helpers.GetIntNumberFromUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int sumOdds = SumOddElements(array);
            Console.WriteLine($"\nCумма элементов массива с нечетными индексами: {sumOdds}");

        }

        public void SolveTask_4_6()
        {
            Helpers helpers = new Helpers();
            int arrayLenght = helpers.GetIntNumberFromUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            GetReversedArrayy(array);
            Console.WriteLine("\nРеверс массива: ");
            helpers.ShowArray(array);

        }

        public void SolveTask_4_7()
        {
            Helpers helpers = new Helpers();
            int arrayLenght = helpers.GetIntNumberFromUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int oddCount = CountOddElements(array);
            Console.WriteLine($"Количество нечетных элементов массива: {oddCount}");
        }

        public void SolveTask_4_8()
        {
            Helpers helpers = new Helpers();
            int arrayLenght = helpers.GetIntNumberFromUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            SwapArrayParts(array);
            helpers.ShowArray(array);
        }

        public void SolveTask_4_9()
        {
            Helpers helpers = new Helpers();
            int arrayLenght = helpers.GetIntNumberFromUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            SelectSort(array);
            helpers.ShowArray(array);
        }

        public void SolveTask_4_10()
        {
            Helpers helpers = new Helpers();
            int arrayLenght = helpers.GetIntNumberFromUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            BubbleSort(array);
            helpers.ShowArray(array);
        }

        public void BubbleSort(int[] array)
        {
            
            int count = 0;
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int index = 0; index < array.Length - count - 1; index++)
                {
                    if (array[index] > array[index + 1])
                    {
                        hw_1.Swap(ref array[index], ref array[index + 1]);
                        flag = true;
                    }

                }
                count++;
            }
        }


        public void SelectSort(int[] array)
        {
            
            for (int index = 0; index < array.Length - 1; index++)
            {
                for (int indexSup = index + 1; indexSup < array.Length; indexSup++)
                {
                    if (array[index] > array[indexSup])
                    {
                        hw_1.Swap(ref array[index], ref array[indexSup]);
                    }
                }
            }
        }

        public void SwapArrayParts(int[] array)
        {
            
            for (int index = 0; index < array.Length / 2; index++)
            {
                
                hw_1.Swap(ref array[index], ref array[array.Length / 2 + index + array.Length % 2]);

            }
        }

        public int CountOddElements(int[] array)
        {
            int oddCount = 0;
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] % 2 != 0)
                {
                    oddCount++;
                }
            }
            return oddCount;
        }

        public void GetReversedArrayy(int[] array)
        {
            for (int index = 0; index < array.Length / 2; index++)
            {
                hw_1.Swap(ref array[index], ref array[array.Length - index - 1]);
            }
        }

        public int SumOddElements(int[] array)
        {
            int sumOdd = 0;
            for (int index = 1; index < array.Length; index+=2)
            {
              
                sumOdd += array[index];
                
            }
            return sumOdd;
        }

        public int GetIndexOfMin(int [] array)
        {
            int minIndex = -1;
            if (array.Length > 0)
            {
                int min = array[0];
                minIndex = 0;
                for (int index = 0; index < array.Length; index++)
                {
                    if (array[index] < min)
                    {
                        min = array[index];
                        minIndex = index;
                    }
                }
            }
            
            return minIndex;
        }

        public int GetIndexOfMax(int[] array)
        {
            int maxIndex = -1;
            if (array.Length > 0)
            {
                int max = array[0];
                maxIndex = 0;
                for (int index = 0; index < array.Length; index++)
                {
                    if (array[index] > max)
                    {
                        max = array[index];
                        maxIndex = index;
                    }
                }
            }
            
            return maxIndex;
        }


        public int GetMax(int[] array)
        {
            int max;
            if (array.Length > 0)
            {
                max = array[0];
                for (int index = 0; index < array.Length; index++)
                {
                    if (array[index] > max)
                    {
                        max = array[index];
                    }
                }
            }
            else
            {
                throw new Exception("Array has no elements");
            }
           
            return max;
        }

        public int GetMin(int[] array)
        {
            int min;
            if (array.Length > 0)
            {
                min = array[0];
                for (int index = 0; index < array.Length; index++)
                {
                    if (array[index] < min)
                    {
                        min = array[index];
                    }
                }
            }
            else
            {
                throw new Exception("Array has no elements");
            }
            
            return min;
        }
    }
}
