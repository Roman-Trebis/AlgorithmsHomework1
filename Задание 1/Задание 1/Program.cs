    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int d = 0;
            int i = 2;

            while(i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
		
		//else
		//{
                    i++;
		//}
            }

            if (d == 0)
            {
                Console.WriteLine("Простое");
            }

            else
            {
                Console.WriteLine("Не простое");
            }

            Console.ReadKey();
        }
    }
}