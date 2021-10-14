using System;
using HelpersList;

namespace Homework_4
{
    public class HW_4
    {
       public void SolveTask_4_1()
        {
            Helpers helpers = new Helpers();
            int arrayLenght = helpers.GetIntNumberFromUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int min = SearchMinInArray(array);
            Console.WriteLine($"\nМинимальное число в массиве: {min}");
        }

        public void SolveTask_4_2()
        {
            Helpers helpers = new Helpers();
            int arrayLenght = helpers.GetIntNumberFromUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int max = SearchMaxInArray(array);
            Console.WriteLine($"\nМаксимальноле число в массиве: {max}");
        }


        public void SolveTask_4_3()
        {
            Helpers helpers = new Helpers();
            int arrayLenght = helpers.GetIntNumberFromUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int minIndex = ReciveIndexMinElement(array);
            Console.WriteLine($"Индекс минимального числа в массиве: {minIndex}");
        }

        public void SolveTask_4_4()
        {
            Helpers helpers = new Helpers();
            int arrayLenght = helpers.GetIntNumberFromUser("Введите длинну массива: ");
            int[] array = new int[arrayLenght];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int maxIndex = ReciveIndexMaxElement(array);
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
            ReversArray(array);
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
            int buffer;
            int count = 0;
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int index = 0; index < array.Length - count - 1; index++)
                {
                    if (array[index] > array[index + 1])
                    {
                        buffer = array[index];
                        array[index] = array[index + 1];
                        array[index + 1] = buffer;
                        flag = true;
                    }

                }
                count++;
            }
        }


        public void SelectSort(int[] array)
        {
            int buffer;
            for (int index = 0; index < array.Length - 1; index++)
            {
                for (int indexSup = index + 1; indexSup < array.Length; indexSup++)
                {
                    if (array[index] > array[indexSup])
                    {
                        buffer = array[index];
                        array[index] = array[indexSup];
                        array[indexSup] = buffer;
                    }
                }
            }
        }

        public void SwapArrayParts(int[] array)
        {
            int buffer;
            for (int index = 0; index < array.Length / 2; index++)
            {
                buffer = array[index];
                array[index] = array[array.Length / 2 + index + array.Length % 2];
                array[array.Length / 2 + index + array.Length % 2] = buffer;
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

        public void ReversArray(int[] array)
        {
            for (int index = 0; index < array.Length / 2; index++)
            {
                int buffer = array[index];
                array[index] = array[array.Length - index - 1];
                array[array.Length - index - 1] = buffer;
            }
        }

        public int SumOddElements(int[] array)
        {
            int sumOdd = 0;
            for (int index = 0; index < array.Length; index+=2)
            {
              
                sumOdd += array[index];
                
            }
            return sumOdd;
        }

        public int ReciveIndexMinElement(int [] array)
        {
            int minIndex = 0;
            int min = array[0];
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < min)
                {
                    min = array[index];
                    minIndex = index;
                }
            }
            return minIndex;
        }

        public int ReciveIndexMaxElement(int[] array)
        {
            int maxIndex = 0;
            int max = array[0];
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] > max)
                {
                    max = array[index];
                    maxIndex = index;
                }
            }
            return maxIndex;
        }


        public int SearchMaxInArray(int[] array)
        {
            int max = array[0];
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] > max)
                {
                    max = array[index];
                }
            }
            return max;
        }

        public int SearchMinInArray(int[] array)
        {
            int min = array[0];
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < min)
                {
                    min = array[index];
                }
            }
            return min;
        }
    }
}
