using System;
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
            Console.WriteLine(OperationsDependingOnComparison(number_1, number_2));

        }

        public void SolveTask_2_2()
        {
            Helpers helpers = new Helpers();
            double X = helpers.GetDoubleNumberFromUser("Введите X: ");
            double Y = helpers.GetDoubleNumberFromUser("Введите Y: ");
            Console.WriteLine(CoordinateSearch(X,Y));

        }

        public void SolveTask_2_3()
        {
            Helpers helpers = new Helpers();
            Console.WriteLine("Введите три числа: ");
            double A = helpers.GetDoubleNumberFromUser("A: ");
            double B = helpers.GetDoubleNumberFromUser("B: ");
            double C = helpers.GetDoubleNumberFromUser("C: ");
            Console.WriteLine(SortThreeIntNumbers(A, B, C));
        }

        public void SolveTask_2_4()
        {
            Helpers helpers = new Helpers();
            Console.WriteLine("Здравствуйте! Введите три числа задающие уровнение стандартного вида AX2+BX+C=0.");
            double A = helpers.GetDoubleNumberFromUser("A: ");
            double B = helpers.GetDoubleNumberFromUser("B: ");
            double C = helpers.GetDoubleNumberFromUser("C: ");
            Console.WriteLine(SolveQuadraticEquation(A, B, C));


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

        public string CoordinateSearch(double X, double Y)
        {

            string resultString = "";
            if (X == 0 || Y == 0)
            {
                if (X == 0 && Y == 0)
                {
                    resultString = "Точка находится в центре координатой оси";
                }
                else
                {
                    resultString = "Точка находится на координатой оси";
                }
            }
            else if (X > 0)
            {
                if (Y > 0)
                {
                    resultString = $"Точка с координатами {X},{Y} пренаделжит первой четверти";
                }
                else
                {
                    resultString = $"Точка с координатами {X},{Y} пренаделжит четвертой четверти";
                }
            }
            else
            {
                if (Y > 0)
                {
                    resultString = $"Точка с координатами {X},{Y} пренаделжит второй четверти";
                }
                else if (X != 0 && Y != 0)
                {
                    resultString = $"Точка с координатами {X},{Y} пренаделжит третьей четверти";
                }
            }
            return resultString;
        }

        public string SortThreeIntNumbers(double A, double B, double C)
        {
            double min = A, max = B, medium = C;
            if (A > B)
            {
                if (A > C)
                {
                    max = A;
                    if (C > B)
                    {
                        medium = C;
                        min = B;
                    }
                    else
                    {
                        medium = B;
                        min = C;
                    }
                }
                else
                {
                    max = C;
                    medium = A;
                    min = B;
                }
            }
            else
            {
                if (B > C)
                {
                    max = B;
                    if (A > C)
                    {
                        medium = A;
                        min = C;
                    }
                    else
                    {
                        min = A;
                    }
                }
                else
                {
                    min = A;
                    medium = B;
                    max = C;
                }
            }
            string resultString = $"Числа в порядке возрастания: {min},{medium},{max}";
            return resultString;
        }

        public string SolveQuadraticEquation(double A, double B, double C)
        {
            double discriminant = Math.Pow(B, 2) - 4 * A * C;
            string resultString;
            if (discriminant >= 0)
            {
                double x1 = (-B + Math.Sqrt(discriminant)) / (2 * A);
                if (discriminant > 0)
                {
                    double x2 = (-B - Math.Sqrt(discriminant)) / (2 * A);
                    resultString = $"У такого квадратного уравнения будет два корня x1 = {x1} и x2 = {x2}";

                }
                else
                {
                    resultString = $"У такого квадратного уравнения будет один корeнь x1 = {x1}";
                }

            }
            else
            {
                resultString = $"У такого квадратного уравнения нет корней";
            }
            return resultString;
        }

        public string OperationsDependingOnComparison(double number_1, double number_2)
        {
            string resultString;
            if (number_1 > number_2)
            {
                resultString = $"A+B = {number_1 + number_2}";
            }
            else if (number_1 < number_2)
            {
                resultString = $"A-B = {number_1 - number_2}";
            }
            else
            {
                resultString = $"A*B = {number_1 * number_2}";
            }
            return resultString;
        }


    }
}
