using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    public class LocalizationDemo
    {
        public static void Execute()
        {
            // Исходные данные
            decimal amount = 12345.67m;
            DateTime date = DateTime.Now;
            double number = 12345.6789;

            // Список культур
            CultureInfo[] cultures = {
            new CultureInfo("en-US"),  // США
            new CultureInfo("fr-FR"),  // Франция
            new CultureInfo("de-DE"),  // Германия
            new CultureInfo("ja-JP"),  // Япония
            new CultureInfo("ru-RU")   // Россия
        };

            foreach (var culture in cultures)
            {
                Console.WriteLine($"\nКультура: {culture.DisplayName}");

                // Форматирование валюты
                Console.WriteLine($"  Валюта: {amount.ToString("C", culture)}");

                // Форматирование даты
                Console.WriteLine($"  Дата: {date.ToString("D", culture)}");

                // Форматирование числа
                Console.WriteLine($"  Число: {number.ToString("N", culture)}");
            }
        }
    }
}
