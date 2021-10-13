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
           int A = helpers.GetIntNumberFromUser("Введите число A:");
           int B = helpers.GetIntNumberFromUser("Введите число B:");
           Console.WriteLine($"Результат деления {A} на {B} будет равен {Divide(A, B)}");
           Console.WriteLine($"Остаток от деления {A} на {B} будет равен {Remainder(A, B)}");

        }
        public void SolveTask_1_4()
        {
            Helpers helpers = new Helpers();
            bool flag = false;
            do
            {
                double A = helpers.GetDoubleNumberFromUser("Введите число A");
                double B = helpers.GetDoubleNumberFromUser("Введите число B");
                double C = helpers.GetDoubleNumberFromUser("Введите число C");
                if (A == 0 || B == 0 || C == 0)
                {
                    Console.WriteLine("Одно из чисел равно нулю");
                    flag = true;
                }
                else
                {
                    flag = false;
                    Console.WriteLine($"Решение(значение X) линейного уравнения стандартного вида, где A * X + B = C: {SolvelinearEquation(A, B, C)}");
                }
            } while (flag == true);
           
        }

        public void SolveTask_1_5()
        {
            Console.WriteLine("Введите 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости: ");
            Helpers helpers = new Helpers();
            double X1 = helpers.GetDoubleNumberFromUser("X1: ");
            double Y1 = helpers.GetDoubleNumberFromUser("Y1: ");
            double X2 = helpers.GetDoubleNumberFromUser("X2: ");
            double Y2 = helpers.GetDoubleNumberFromUser("Y2: ");
            Console.WriteLine(SolveCanonlinearEquation(X1, Y1, X2, Y2));
        }


        public double CalculateResult(double numberA, double numberB)
        {
            double calculationResult = (5 * numberA + Math.Pow(numberB, 2)) / (numberA - numberB);
            return calculationResult;
        }

        public void Swap(ref string str1, ref string str2)
        {
            string buffer = str1;
            str1 = str2;
            str2 = buffer;
        }

        public int Divide(int number_1, int number_2)
        {
            int result = number_1 / number_2;
            return result;
        }
        public int Remainder(int number_1, int number_2)
        {
            int result = number_1 % number_2;
            return result;
        }
        public double SolvelinearEquation(double A, double B, double C)
        {
            double X = (C - B) / A;
            return X;
        }

        public string SolveCanonlinearEquation(double X1, double Y1, double X2, double Y2)
        {
            double k = (Y2 - Y1) / (X2 - X1);
            double b = k * X1 - Y1;
            string result = $"Уравнение прямой проходящей через эти точки: Y = {k}X + {b}";
            return result;
        }

    }
}
