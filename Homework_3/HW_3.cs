using System;
using HelpersList;
using Homework_1;

namespace Homework_3
{
    public class HW_3
    {
        public HW_1 hw_1 = new HW_1();
        public void SolveTask_3_1()
        {
            Helpers helpers = new Helpers();
            double number = helpers.GetDoubleNumberFromUser("Введите число: ");
            double power = helpers.GetDoubleNumberFromUser("Введите степень: ");
            Console.WriteLine($"Число {number} в степени {power} будет равно {PowerNumber(number, power)}");
        }

        public void SolveTask_3_2()
        {
            Helpers helpers = new Helpers();
            int number = helpers.GetIntNumberFromUser("Введите число: ");
            int[] resultArray = FindAllNumbersThatAreDivisibleByANumber(number);
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write($"{resultArray[i]}\t");
            }
        }

        public void SolveTask_3_3()
        {
            Helpers helpers = new Helpers();
            int number = helpers.GetIntNumberFromUser("Введите число: ");
            Console.WriteLine($"Rоличество положительных целых чисел, квадрат которых меньше A: {CountNumbersWhoseSquareIsLessThan(number)}"); 
        }


        public void SolveTask_3_4()
        {
            Helpers helpers = new Helpers();
            int number = helpers.GetIntNumberFromUser("Введите число: ");
            Console.WriteLine($"Наибольший делитель (кроме самого числа {number}) числа {number}: {SearchMaxDivider(number)}");

        }

        public void SolveTask_3_5()
        {
            Helpers helpers = new Helpers();
            int a = helpers.GetIntNumberFromUser("Введите число A: ");
            int b = helpers.GetIntNumberFromUser("Введите число B: ");
            Console.WriteLine($"Cумма всех чисел из диапазона от A до B, которые делятся без остатка на 7: {SumAllNumbersInRangeThatDivBySeven(a, b)}");
        }

        public void SolveTask_3_6()
        {
            Helpers helpers = new Helpers();
            int number = helpers.GetIntNumberFromUser("Введите число: ");
            Console.WriteLine($"{number}-ое число ряда фибоначчи: {SearchFibbonachiNumber(number)}");
        }
        public void SolveTask_3_7()
        {
            Helpers helpers = new Helpers();
            int a = helpers.GetIntNumberFromUser("Введите первое число: "); 
            int b = helpers.GetIntNumberFromUser("Введите второе число: ");
            Console.WriteLine($"Их наибольший общий делитель {Math.Abs(CalculateGreatestCommonFactor(a, b))}");
        }

        public void SolveTask_3_8()
        {
            double number;
            do
            {
                Helpers helpers = new Helpers();
                number = helpers.GetDoubleNumberFromUser("Введите положительное число: ");
                if(number < 0)
                {
                    Console.WriteLine("Число отрицательное.");
                }
            } while (number < 0);
            Console.WriteLine($"Целое положительное число, которое является кубом целого числа {number} будет равным {FindCubeOfNumberUsingTheHalfDivisionMethod(number)}");
        }

        public void SolveTask_3_9()
        {
            Helpers helpers = new Helpers();
            int number = helpers.GetIntNumberFromUser("Введите число: ");
            Console.WriteLine($"Количество нечетных числе в числе {number} состовляет {CountOddNumbers(number)}");
        }

        public void SolveTask_3_10()
        {
            Helpers helpers = new Helpers();
            int number = helpers.GetIntNumberFromUser("Введите число: ");
            Console.WriteLine($"Число {number} наоборот будет {ReverseNumber(number)}");
        }


        public void SolveTask_3_11()
        {
            Helpers helpers = new Helpers();
            int number = helpers.GetIntNumberFromUser("Введите число: ");
            int[] resultArray = SearchNumbersSumEvenIsGreaterSumOfOdd(number);
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write($"{resultArray[i]}\t");
            }
            

        }


        public void SolveTask_3_12()
        {
            Helpers helpers = new Helpers();
            int numberA = helpers.GetIntNumberFromUser("Введите первое число: ");
            int numberB = helpers.GetIntNumberFromUser("Введите второе число: ");
            if (CheckSameDigits(numberA, numberB))
            {
                Console.WriteLine("ДА");
            }
            else
            {
                Console.WriteLine("НЕТ");
            }
        }

        public bool CheckSameDigits(int operationBufferA, int operationBufferB)
        {
            int digitA;
            int digitB;
            bool answer = false;
            do
            {
                digitA = operationBufferA % 10;
                do
                {
                    digitB = operationBufferB % 10;
                    if (digitA == digitB)
                    {
                        answer = true;
                    }

                    operationBufferB /= 10;
                } while (operationBufferB > 0);

                operationBufferA /= 10;
            } while (operationBufferA > 0);
            return answer;
        }
        public int[] SearchNumbersSumEvenIsGreaterSumOfOdd(int number)
        {
            int operationBuffer;
            int evenSum = 0;
            int oddSum = 0;
            int arrayLenght = 0;

            for (int count = 0; count < number; count++)
            {
                operationBuffer = count;
                while (operationBuffer >= 1)
                {
                    if ((operationBuffer % 10) % 2 != 0 && (operationBuffer % 10) != 0)
                    {
                        oddSum += operationBuffer % 10;
                    }
                    if ((operationBuffer % 10) % 2 == 0 && (operationBuffer % 10) != 0)
                    {
                        evenSum += operationBuffer % 10;
                    }

                    operationBuffer /= 10;
                }
                if (evenSum > oddSum)
                {
                    arrayLenght ++;
                }
                oddSum = 0;
                evenSum = 0;
            }
            int[] resultArray = new int[arrayLenght];
            int arrayIndex = 0;
            for (int count = 0; count < number; count++)
            {
                operationBuffer = count;
                while (operationBuffer >= 1)
                {
                    if ((operationBuffer % 10) % 2 != 0 && (operationBuffer % 10) != 0)
                    {
                        oddSum += operationBuffer % 10;
                    }
                    if ((operationBuffer % 10) % 2 == 0 && (operationBuffer % 10) != 0)
                    {
                        evenSum += operationBuffer % 10;
                    }

                    operationBuffer /= 10;
                }
                if (evenSum > oddSum)
                {
                    resultArray[arrayIndex] = count;
                    arrayIndex++;
                }
                oddSum = 0;
                evenSum = 0;
            }
            return resultArray;
        }

        public int ReverseNumber(int number)
        {
           
            int reverseNumber = 0;
            int numberBuffer = number;
            while (numberBuffer > 0)
            {
                reverseNumber = reverseNumber*10 + numberBuffer % 10 ;
                numberBuffer /= 10;
            }
            return reverseNumber;
        }

        public int CountOddNumbers(int number)
        {
            int count = 0;
            int operationBuffer = number;

            while (operationBuffer >= 1)
            {
                if ((operationBuffer % 10) % 2 != 0 && (operationBuffer % 10) != 0)
                {
                    count++;
                }

                operationBuffer /= 10;
            }
            return count;
        }

        public double FindCubeOfNumberUsingTheHalfDivisionMethod(double number)
        {
            double rangeMax = number;
            double rangeMin = 0;
            double result = 0;

            while (rangeMax - rangeMin > 0.01)
            {
                result = (rangeMax + rangeMin) / 2;
                if (result * result * result > number)
                {
                    rangeMax = result;

                }
                else
                {
                    rangeMin = result;
                }
            }
            return Math.Round(result, 1);
        }

        public int CalculateGreatestCommonFactor(int numberA, int numberB)
        {
            int result = 1;
            int max = numberA;
            int rem;
            int min = numberB;
            if (numberB > numberA)
            {
                max = numberB;
                min = numberA;
            }
            do
            {
                result = max / min;
                rem = max % min;
                if (rem != 0)
                {
                    max = min;
                    min = rem;
                }
            } while (rem != 0);
            return min;
        }

        public int SearchFibbonachiNumber(int number)
        {
            int fibbonachiNumber = 0;
            int fibbonachiNumber_1 = 0;
            int fibbonachiNumber_2 = 1;
            if(number < 1)
            {
                throw new ArgumentException("Числа Фибоначчи начинаются с 1!");
            }
            for (int count = 2; count <= number; count++)
            {
                fibbonachiNumber = fibbonachiNumber_1 + fibbonachiNumber_2;
                fibbonachiNumber_2 = fibbonachiNumber - fibbonachiNumber_2;
                fibbonachiNumber_1 = fibbonachiNumber;
            }
            return fibbonachiNumber;
        }

        public int SumAllNumbersInRangeThatDivBySeven(int rangeA, int rangeB)
        {
            int result = 0;
            int max = rangeA;
            int min = rangeB;
            
            if (max < min)
            {
                hw_1.Swap(ref max, ref min);
            }
          
            for (int count = min; count < max; count++)
            {
                if (count % 7 == 0)
                {
                    result += count;
                }
            }
            return result;
        }

        public int SearchMaxDivider(int number)
        {
            int maxDivider = 1;
            for (int count = Math.Abs(number); count > 0; count--)
            {
                if (Math.Abs(number) % count == 0 && count != Math.Abs(number))
                {
                    maxDivider = count;
                    break;
                }
            }
            return maxDivider;
        }

        public double PowerNumber(double number, double power)
        {
            double result = 1;
            //result = Math.Pow(A, B); 
            if (power >= 0)
            {
                for (int count = 0; count < power; count++)
                {
                    result *= number;
                }
            }
            else
            {
                for (int count = 0; count < Math.Abs(power); count++)
                {
                    result *= 1 / number;
                }
            }
            return result;
        }
        
        public int[] FindAllNumbersThatAreDivisibleByANumber(int number)
        {
            int count = 0;
            for (int i = number; i < 1000; i++)
            {
                if (i % number == 0)
                {
                    count++;
                }
            }
            int[] resultArray = new int[count];
            int arrayCount = 0;
            for (int i = number; i < 1000; i++)
            {
                if (i % number == 0)
                {
                    resultArray[arrayCount] = i;
                    arrayCount++;
                }
            }
            return resultArray;
        }

        public int CountNumbersWhoseSquareIsLessThan(int number)
        {
            int count = 0;
            for (int i = 0; Math.Pow(i, 2) < number; i++)
            {
                count++;
            }
            return count;
        }

    }



}
