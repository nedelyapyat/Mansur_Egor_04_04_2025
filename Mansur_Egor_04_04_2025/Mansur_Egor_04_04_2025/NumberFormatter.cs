using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    class NumberFormatter
    {
        public static void Execute()
        {
            Console.Write("Введите число с плавающей точкой: ");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
            {
                Console.WriteLine($"Оригинальное число: {number}");
                Console.WriteLine($"Фиксированный формат (2 знака после запятой): {number:F2}");
                Console.WriteLine($"Фиксированный формат (4 знака после запятой): {number:F4}");
                Console.WriteLine($"Экспоненциальное представление (научный формат): {number:E}");
                Console.WriteLine($"Экспоненциальное представление (4 знака после запятой): {number:E4}");
                Console.WriteLine($"Формат валюты: {number:C}");
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите корректное число.");
            }
        }
    }
}
