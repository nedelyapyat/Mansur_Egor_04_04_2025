using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    class StringEfficiencyTester
    {
        public static void Execute()
        {
            const int iterations = 1000;
            const string pattern = "SampleText";

            Console.WriteLine("Сравнение эффективности создания строк:");

            // Измерение времени для обычной конкатенации
            Stopwatch stopwatch = Stopwatch.StartNew();
            string concatenatedString = "";
            for (int i = 0; i < iterations; i++)
            {
                concatenatedString += pattern;
            }
            stopwatch.Stop();
            Console.WriteLine($"Обычная конкатенация: {stopwatch.ElapsedMilliseconds} мс");

            // Измерение времени для StringBuilder
            stopwatch.Restart();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                sb.Append(pattern);
            }
            string builtString = sb.ToString();
            stopwatch.Stop();
            Console.WriteLine($"StringBuilder: {stopwatch.ElapsedMilliseconds} мс");
        }
    }
}
