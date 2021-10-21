using HelpersList;
using System;


namespace Homework_1
{
    public class HW_1
    {
        public void SolveTask_1_1()
        {
            Helpers helpers = new Helpers();
            double a = helpers.GetDoubleNumberFromUser("Введите число A:");
            double b = helpers.GetDoubleNumberFromUser("Введите число B:");
            Console.WriteLine($"Результат сложения:{CalculateResult(a,b)}" ); 

        }

        public void SolveTask_1_2()
        {
            Helpers helpers = new Helpers();
            string str1 = helpers.GetStringFromUser("Введите первую строку:");
            string str2 = helpers.GetStringFromUser("Введите вторую строку:");
            Swap(ref str1, ref str2);
            Console.WriteLine($"Первая строка: {str1}");
            Console.WriteLine($"Вторая строка: {str2}");
        }

        public void SolveTask_1_3()
        {
           Helpers helpers = new Helpers();
           int numberA = helpers.GetIntNumberFromUser("Введите число A:");
           int numberB = helpers.GetIntNumberFromUser("Введите число B:");
           Console.WriteLine($"Результат деления {numberA} на {numberB} будет равен {Divide(numberA, numberB)}");
           Console.WriteLine($"Остаток от деления {numberA} на {numberB} будет равен {FindRemainder(numberA, numberB)}");

        }
        public void SolveTask_1_4()
        {
            Helpers helpers = new Helpers();
            bool flag = false;
            do
            {
                double numberA = helpers.GetDoubleNumberFromUser("Введите число A");
                double numberB = helpers.GetDoubleNumberFromUser("Введите число B");
                double numberC = helpers.GetDoubleNumberFromUser("Введите число C");
                if (numberA == 0 || numberB == 0 || numberC == 0)
                {
                    Console.WriteLine("Одно из чисел равно нулю");
                    flag = true;
                }
                else
                {
                    flag = false;
                    Console.WriteLine($"Решение(значение X) линейного уравнения стандартного вида, где A * X + B = C: {SolveLinearEquation(numberA, numberB, numberC)}");
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
                resultArray = GetLinearEquation(x1, y1, x2, y2);
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

        public void Swap(ref int numberA, ref int numberB)
        {
            int buffer = numberA;
            numberA = numberB;
            numberA = buffer;
        }


        public int Divide(int numberA, int numberB)
        {
            int result = numberA / numberB;
            return result;
        }
        public int FindRemainder(int numberA, int numberB)
        {
            int result = numberA % numberB;
            return result;
        }
        public double SolveLinearEquation(double numberA, double numberB, double numberC)
        {
            if (numberA == 0)
            {
                throw new ArgumentException("Происходит деление на нуль");
            }
            double x = (numberC - numberB) / numberA;
            return x;
        }

        public double[] GetLinearEquation(double x1, double y1, double x2, double y2)
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
