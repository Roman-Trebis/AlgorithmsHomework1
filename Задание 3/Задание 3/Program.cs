using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3
{
    class Fibonaci
    {
        public int FibonaciRecursion(int fNumber)
        {
            return (fNumber == 0 || fNumber == 1) ? 1 : FibonaciRecursion(fNumber - 2) + FibonaciRecursion(fNumber - 1);
        }

        public int FibonaciCycle(int fNumber)
        {
            int FNumberOne = 1;
            int FNumberTwo = 1;
            int FNumberResult = 1;

            for (int i = 2; i <= fNumber; i++)
            {
                FNumberResult = FNumberOne + FNumberTwo;
                FNumberTwo = FNumberOne;
                FNumberOne = FNumberResult;
            }
            return FNumberResult;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Fibonaci fibonaci = new Fibonaci();
            fibonaci.FibonaciRecursion(number);
            fibonaci.FibonaciCycle(number);

            Console.WriteLine("Рекурсивный метод: ");
            for (int i = 0; i < number; i++)
            {
                var s = i + 1 == number ? string.Empty : ", ";
                Console.WriteLine($"{fibonaci.FibonaciRecursion(i)}{s}");
            }

            Console.WriteLine("Циклический метод: ");
            for (int i = 0; i < number; i++)
            {
                var s = i + 1 == number ? string.Empty : ", ";
                Console.WriteLine($"{fibonaci.FibonaciCycle(i)}{s}");
            }

            Console.ReadKey();
        }
    }
}