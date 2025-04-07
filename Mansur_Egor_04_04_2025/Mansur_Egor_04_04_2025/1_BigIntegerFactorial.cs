using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    internal class BigIntegerFactorial
    {
        public static void Execute()
        {
            Console.Write("Введите число для вычисления факториала: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                BigInteger result = CalculateFactorial(number);
                Console.WriteLine($"Факториал {number} равен {result}");
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
            }
        }

        private static BigInteger CalculateFactorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Факториал определён только для неотрицательных чисел.");

            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}