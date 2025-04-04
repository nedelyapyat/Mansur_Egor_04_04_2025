using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    class ComplexNumberOperations
    {
        public static void Execute()
        {
            Console.WriteLine("Введите первое комплексное число (в формате a b, где a — действительная часть, b — мнимая):");
            if (!TryParseComplex(Console.ReadLine(), out Complex num1))
            {
                Console.WriteLine("Ошибка ввода. Попробуйте снова.");
                return;
            }

            Console.WriteLine("Введите второе комплексное число (в формате a b, где a — действительная часть, b — мнимая):");
            if (!TryParseComplex(Console.ReadLine(), out Complex num2))
            {
                Console.WriteLine("Ошибка ввода. Попробуйте снова.");
                return;
            }

            Console.WriteLine($"Сложение: {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"Вычитание: {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Умножение: {num1} * {num2} = {num1 * num2}");

            if (num2 != Complex.Zero)
            {
                Console.WriteLine($"Деление: {num1} / {num2} = {num1 / num2}");
            }
            else
            {
                Console.WriteLine("Ошибка: деление на ноль");
            }
        }

        private static bool TryParseComplex(string input, out Complex result)
        {
            result = Complex.Zero;
            string[] parts = input.Split();
            if (parts.Length != 2 || !double.TryParse(parts[0], out double real) || !double.TryParse(parts[1], out double imaginary))
            {
                return false;
            }
            result = new Complex(real, imaginary);
            return true;
        }
    }
}
