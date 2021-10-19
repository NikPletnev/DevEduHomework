﻿using System;
using HelpersList;

namespace Homework_2
{
    public class HW_2
    {

        public void SolveTask_2_1()
        {
            Helpers helpers = new Helpers();
            double number_1 = helpers.GetDoubleNumberFromUser("Введите первое число: ");
            double number_2 = helpers.GetDoubleNumberFromUser("Введите второе число: ");
            Console.WriteLine(SolveOperationsDependingOnComparison(number_1, number_2));

        }

        public void SolveTask_2_2()
        {
            Helpers helpers = new Helpers();
            double x = helpers.GetDoubleNumberFromUser("Введите X: ");
            double y = helpers.GetDoubleNumberFromUser("Введите Y: ");
            WriteCoordinateQuarter(FindTheCoordinateQuarter(x,y), x, y);

        }

        public void SolveTask_2_3()
        {
            Helpers helpers = new Helpers();
            Console.WriteLine("Введите три числа: ");
            double a = helpers.GetDoubleNumberFromUser("A: ");
            double b = helpers.GetDoubleNumberFromUser("B: ");
            double c = helpers.GetDoubleNumberFromUser("C: ");
            SortThreeIntNumbers(ref a, ref b, ref c);
            Console.WriteLine($"Числа в порядке возрастания: {a},{b},{c}");
        }

        public void SolveTask_2_4()
        {
            Helpers helpers = new Helpers();
            Console.WriteLine("Здравствуйте! Введите три числа задающие уровнение стандартного вида AX2+BX+C=0.");
            double a = helpers.GetDoubleNumberFromUser("A: ");
            double b = helpers.GetDoubleNumberFromUser("B: ");
            double c = helpers.GetDoubleNumberFromUser("C: ");
            double[] resultArray = SolveQuadraticEquation(a, b, c);
            switch (resultArray[0])
            {
                case 2:
                    Console.WriteLine($"У такого квадратного уравнения будет два корня x1 = {resultArray[1]} и x2 = {resultArray[2]}"); 
                    break;
                case 1:
                    Console.WriteLine($"У такого квадратного уравнения будет один корeнь x1 = {resultArray[1]}");
                    break;
                default:
                    Console.WriteLine($"У такого квадратного уравнения нет корней");
                    break;
            }


        }

        public void SolveTask_2_5()
        {
            Helpers helpers = new Helpers();
            bool flag = false;
            do
            {
                int number = helpers.GetIntNumberFromUser("Введите двузначное число: ");
                if (number > 10 && number < 100)
                {
                    Console.WriteLine(ParseIntToLiteralString(number));
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Число не двузначное");
                    flag = true;
                }


            } while (flag);
           

        }



        public string ParseIntToLiteralString(int number)
        {
            string resultString = "";
            string leftPart, rightPart; ;
            if (number < 20)
            {
                resultString = number switch
                {
                    11 => "Одинадцать",
                    12 => "Двенадцать",
                    13 => "Тринадцать",
                    14 => "Четырнадцать",
                    15 => "Пятнадцать",
                    16 => "Шестнадцать",
                    17 => "Семнадцать",
                    18 => "Восемнадцать",
                    19 => "Девятнадцать",
                    _ => "Error",
                };
            }
            else
            {
                leftPart = (number / 10) switch
                {
                    2 => "Двадцать",
                    3 => "Тридцать",
                    4 => "Сорок",
                    5 => "Пятдесят",
                    6 => "Шесдесят",
                    7 => "Семдесят",
                    8 => "Восемдесят",
                    9 => "Девяносто",
                    _ => "Error",
                };
                rightPart = (number % 10) switch
                {
                    1 => "Один",
                    2 => "Два",
                    3 => "Три",
                    4 => "Четыре",
                    5 => "Пять",
                    6 => "Шесть",
                    7 => "Семь",
                    8 => "Восемь",
                    9 => "Девять",
                    _ => "Error",
                };
                resultString = leftPart + " " + rightPart;
            }
                return resultString;
            

        }

        public double FindTheCoordinateQuarter(double x, double y)
        {

            double coordinateQuarter = 0;
            if (x == 0 || y == 0)
            {
                if (x == 0 && y == 0)
                {
                    coordinateQuarter = 0;
                }
                else
                {
                    coordinateQuarter = 0;
                }
            }
            else if (x > 0)
            {
                if (y > 0)
                {
                    coordinateQuarter = 1;
                }
                else
                {
                    coordinateQuarter = 4;
                }
            }
            else
            {
                if (y > 0)
                {
                    coordinateQuarter = 2;
                }
                else if (x != 0 && y != 0)
                {
                    coordinateQuarter = 3; 
                }
            }
            return coordinateQuarter;
        }

        public void WriteCoordinateQuarter(double quarterNumber, double x, double y)
        {
            switch (quarterNumber)
            {
                case 1:
                    Console.WriteLine($"Точка с координатами {x},{y} пренаделжит первой четверти");
                    break;
                case 2:
                    Console.WriteLine($"Точка с координатами {x},{y} пренаделжит второй четверти");
                    break;
                case 3:
                    Console.WriteLine($"Точка с координатами {x},{y} пренаделжит третьей четверти");
                    break;
                case 4:
                    Console.WriteLine($"Точка с координатами {x},{y} пренаделжит четвертой четверти");
                    break;

                default:
                    Console.WriteLine("Точка находится в центре координатой оси или на координатной оси");
                    break;
            }
        }


        public void SortThreeIntNumbers(ref double a, ref double b, ref double c)
        {
            double min = a, max = b, medium = c;
            if (a > b)
            {
                if (a > c)
                {
                    max = a;
                    if (c > b)
                    {
                        medium = c;
                        min = b;
                    }
                    else
                    {
                        medium = b;
                        min = c;
                    }
                }
                else
                {
                    max = c;
                    medium = a;
                    min = b;
                }
            }
            else
            {
                if (b > c)
                {
                    max = b;
                    if (a > c)
                    {
                        medium = a;
                        min = c;
                    }
                    else
                    {
                        min = a;
                    }
                }
                else
                {
                    min = a;
                    medium = b;
                    max = c;
                }
            }
            a = min;
            b = medium;
            c = max;
        }

        public double[] SolveQuadraticEquation(double A, double B, double C)
        {
            double discriminant = Math.Pow(B, 2) - 4 * A * C;
            double[]  resultArray = new double[3];

            if (discriminant >= 0)
            {
                double x1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
                if (discriminant > 0)
                {
                    double x2 = (-B - Math.Sqrt(discriminant)) / (2 * A);
                    resultArray[0] = 2;
                    resultArray[1] = x1;
                    resultArray[2] = x2;
                }
                else
                {
                    resultArray[0] = 1;
                    resultArray[1] = x1;
                }
            }
            else
            {
                resultArray[0] = 0;
            }
            return resultArray;
        }

        public double SolveOperationsDependingOnComparison(double number_1, double number_2)
        {
            double result;
            if (number_1 > number_2)
            {
                result = number_1 + number_2;
            }
            else if (number_1 < number_2)
            {
                result = number_1 - number_2;
            }
            else
            {
                result = number_1 * number_2;
            }
            return result;
        }


    }
}
