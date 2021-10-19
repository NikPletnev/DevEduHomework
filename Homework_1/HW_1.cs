using HelpersList;
using System;


namespace Homework_1
{
    public class HW_1
    {
        public void SolveTask_1_1()
        {
            Helpers helpers = new Helpers();
            double A = helpers.GetDoubleNumberFromUser("Введите число A:");
            double B = helpers.GetDoubleNumberFromUser("Введите число B:");
            Console.WriteLine($"Результат сложения:{CalculateResult(A,B)}" ); 

        }

        public void SolveTask_1_2()
        {
            Helpers helpers = new Helpers();
            string str_1 = helpers.GetStringFromUser("Введите первую строку:");
            string str_2 = helpers.GetStringFromUser("Введите вторую строку:");
            Swap(ref str_1, ref str_2);
            Console.WriteLine($"Первая строка: {str_1}");
            Console.WriteLine($"Вторая строка: {str_2}");
        }

        public void SolveTask_1_3()
        {
           Helpers helpers = new Helpers();
           int number_a = helpers.GetIntNumberFromUser("Введите число A:");
           int number_b = helpers.GetIntNumberFromUser("Введите число B:");
           Console.WriteLine($"Результат деления {number_a} на {number_b} будет равен {Divide(number_a, number_b)}");
           Console.WriteLine($"Остаток от деления {number_a} на {number_b} будет равен {FindRemainder(number_a, number_b)}");

        }
        public void SolveTask_1_4()
        {
            Helpers helpers = new Helpers();
            bool flag = false;
            do
            {
                double number_a = helpers.GetDoubleNumberFromUser("Введите число A");
                double number_b = helpers.GetDoubleNumberFromUser("Введите число B");
                double number_c = helpers.GetDoubleNumberFromUser("Введите число C");
                if (number_a == 0 || number_b == 0 || number_c == 0)
                {
                    Console.WriteLine("Одно из чисел равно нулю");
                    flag = true;
                }
                else
                {
                    flag = false;
                    Console.WriteLine($"Решение(значение X) линейного уравнения стандартного вида, где A * X + B = C: {SolveLinearEquation(number_a, number_b, number_c)}");
                }
            } while (flag == true);
           
        }

        public void SolveTask_1_5()
        {
            Console.WriteLine("Введите 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости: ");
            Helpers helpers = new Helpers();
            double x1 = helpers.GetDoubleNumberFromUser("X1: ");
            double y1 = helpers.GetDoubleNumberFromUser("Y1: ");
            double x2 = helpers.GetDoubleNumberFromUser("X2: ");
            double y2 = helpers.GetDoubleNumberFromUser("Y2: ");
            if (x1 == x2)
            {
                Console.WriteLine($"Уравнение прямой проходящей через эти точки: X = {x1}");
            }else if (y1 == y2)
            {
                Console.WriteLine($"Уравнение прямой проходящей через эти точки: X = {x1}");
            }
            else
            {
                double[] resultArray = new double[2];
                resultArray = ReductionToLinearEquation(x1, y1, x2, y2);
                Console.WriteLine($"Уравнение прямой проходящей через эти точки: Y = {resultArray[0]}X + {resultArray[1]}");
            }

           
            
        }


        public double CalculateResult(double numberA, double numberB)
        {
            if (numberA == numberB)
            {
                throw new ArgumentException("Значения A и B должны быть разными");
            }
            double calculationResult = (5 * numberA + Math.Pow(numberB, 2)) / (numberA - numberB);
            return calculationResult;
        }

        public void Swap(ref string str1, ref string str2)
        {
            string buffer = str1;
            str1 = str2;
            str2 = buffer;
        }

        public void Swap(ref int number_1, ref int number_2)
        {
            int buffer = number_1;
            number_1 = number_2;
            number_2 = buffer;
        }


        public int Divide(int number_1, int number_2)
        {
            int result = number_1 / number_2;
            return result;
        }
        public int FindRemainder(int number_1, int number_2)
        {
            int result = number_1 % number_2;
            return result;
        }
        public double SolveLinearEquation(double number_a, double number_b, double number_c)
        {
            if (number_a == 0)
            {
                throw new ArgumentException("Происходит деление на нуль");
            }
            double x = (number_c - number_b) / number_a;
            return x;
        }

        public double[] ReductionToLinearEquation(double x1, double y1, double x2, double y2)
        {
            double k = (y2 - y1) / (x2 - x1);
            double b = k * x1 - y1;
            double[] resultArray = new double[2];
            resultArray[0] = k;
            resultArray[1] = b;
            return resultArray;
        }

    }
}
