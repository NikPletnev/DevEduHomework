using System;

namespace HelpersList
{
    public class Helpers
    {
        public int GetIntNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;

        }
        public double GetDoubleNumberFromUser(string message)
        {
            Console.WriteLine(message);
            double number = Convert.ToDouble(Console.ReadLine());
            return number;

        }
        public string GetStringFromUser(string message)
        {
            Console.WriteLine(message);
            string str = Console.ReadLine();
            return str;
        }

        public void RandomizeArray(int[] array)
        {
            Random rnd = new Random();
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = rnd.Next(100);
            }
        }

        public void RandomizeArray(int[,] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(100);
                }
            }
        }

        public void ShowArray(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                Console.Write(array[index] + "\t");
            }
            Console.WriteLine("");
        }

        public void ShowArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }

                Console.WriteLine("");
            }
        }


    }
}
