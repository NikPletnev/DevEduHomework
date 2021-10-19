using System;
using HelpersList;
using Homework_1;

namespace Homework_5
{
    public class HW_5
    {
        HW_1 hw_1 = new HW_1();
        public void SolveTask_5_1()
        {
            Helpers helpers = new Helpers();
            int arrayLenghtRows = helpers.GetIntNumberFromUser("Введите количество строк: ");
            int arrayLenghtColumns = helpers.GetIntNumberFromUser("Введите количество столбцов: ");
            int[,] array = new int[arrayLenghtRows, arrayLenghtColumns];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int min = SerachMinInArray(array);
            Console.WriteLine($"Минимальное значение: {min}");
        }

        public void SolveTask_5_2()
        {
            Helpers helpers = new Helpers();
            int arrayLenghtRows = helpers.GetIntNumberFromUser("Введите количество строк: ");
            int arrayLenghtColumns = helpers.GetIntNumberFromUser("Введите количество столбцов: ");
            int[,] array = new int[arrayLenghtRows, arrayLenghtColumns];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int max = SerachMaxInArray(array);
            Console.WriteLine($"Максимальное значение: {max}");
        }


        public void SolveTask_5_3()
        {
            Helpers helpers = new Helpers();
            int arrayLenghtRows = helpers.GetIntNumberFromUser("Введите количество строк: ");
            int arrayLenghtColumns = helpers.GetIntNumberFromUser("Введите количество столбцов: ");
            int[,] array = new int[arrayLenghtRows, arrayLenghtColumns];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int[] minIndex = GetIndexMinElement(array);
            Console.WriteLine($"Индекс минимального значения: ({minIndex[0]} , {minIndex[1]})");
        }

        public void SolveTask_5_4()
        {
            Helpers helpers = new Helpers();
            int arrayLenghtRows = helpers.GetIntNumberFromUser("Введите количество строк: ");
            int arrayLenghtColumns = helpers.GetIntNumberFromUser("Введите количество столбцов: ");
            int[,] array = new int[arrayLenghtRows, arrayLenghtColumns];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int[] maxIndex = GetIndexMaxElement(array);
            Console.WriteLine($"Индекс максимального значения: ({maxIndex[0]} , {maxIndex[1]})");
        }


        public void SolveTask_5_5()
        {
            Helpers helpers = new Helpers();
            int arrayLenghtRows = helpers.GetIntNumberFromUser("Введите количество строк: ");
            int arrayLenghtColumns = helpers.GetIntNumberFromUser("Введите количество столбцов: ");
            int[,] array = new int[arrayLenghtRows, arrayLenghtColumns];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            int count = NumberOfElementsThatMoreThanNeighbors(array);
            Console.WriteLine($"Общее количество элементов, которые больше своих соседей {count}");

        }

        public void SolveTask_5_6()
        {
            Helpers helpers = new Helpers();
            int arrayLenghtRows = helpers.GetIntNumberFromUser("Введите количество строк: ");
            int arrayLenghtColumns = helpers.GetIntNumberFromUser("Введите количество столбцов: ");
            int[,] array = new int[arrayLenghtRows, arrayLenghtColumns];
            helpers.RandomizeArray(array);
            helpers.ShowArray(array);
            FlipDiagonally(array);
            Console.WriteLine("Транспонированная матрица:");
            helpers.ShowArray(array);
        }


        public void FlipDiagonally(int[,] array)
        {
            int buffer;
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    hw_1.Swap(ref array[i, j], ref array[j, i]);
                }
            }
        }


        public int NumberOfElementsThatMoreThanNeighbors(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if ((i + 1 == array.GetLength(0) || array[i, j] > array[i + 1, j]) &&
                        (j + 1 == array.GetLength(1) || array[i, j] > array[i, j + 1]) && 
                        (i == 0 || array[i, j] > array[i - 1, j]) && 
                        (j == 0 || array[i, j] > array[i, j - 1]))
                    {
                        count++;
                        //Console.WriteLine($"Элемент массива под индексом ({i} , {j}) со значением {array[i,j]} является наибольшим среди своих соседей.");
                    }
                }
            }
            return count;
        }

        public int[] GetIndexMinElement(int[,] array)
        {
            int min = 0;
            int[] minIndex = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        min = array[i, j];
                        minIndex[0] = 0;
                        minIndex[1] = 0;
                    }
                    else
                    {
                        if (min > array[i, j])
                        {
                            min = array[i, j];
                            minIndex[0] = i;
                            minIndex[1] = j;
                        }
                    }
                }
            }
            return minIndex;
        }

        public int[] GetIndexMaxElement(int[,] array)
        {
            int max = 0;
            int[] maxIndex = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        max = array[i, j];
                        maxIndex[0] = 0;
                        maxIndex[1] = 0; 
                    }
                    else
                    {
                        if (max < array[i, j])
                        {
                            max = array[i, j];
                            maxIndex[0] = i;
                            maxIndex[1] = j; 
                        }
                    }
                }
            }
            return maxIndex;
        }


        public int SerachMinInArray(int[,] array)
        {
            int min = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        min = array[i, j];
                    }
                    else
                    {
                        min = min > array[i, j] ? array[i, j] : min;
                    }
                }
            }

            return min;
        }
        public int SerachMaxInArray(int[,] array)
        {
            int max = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0 && j == 0)
                    {
                        max = array[i, j];
                    }
                    else
                    {
                        max = max < array[i, j] ? array[i, j] : max;
                    }
                }
            }

            return max;
        }


    }
}
