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
    }
}
