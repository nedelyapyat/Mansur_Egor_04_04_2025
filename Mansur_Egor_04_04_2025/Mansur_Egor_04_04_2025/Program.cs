using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mansur_Egor_04_04_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер задания (от 1 до 15) или 0 для выхода:");
                if (int.TryParse(Console.ReadLine(), out int taskNumber))
                {
                    if (taskNumber == 0) break;

                    switch (taskNumber)
                    {
                        case 1:
                            BigIntegerFactorial.Execute();
                            break;
                        case 2:
                            ComplexNumberOperations.Execute();
                            break;
                        case 3:
                            NumberFormatter.Execute();
                            break;
                        case 4:
                            StringProcessor.Execute();
                            break;
                        case 5:
                            StringEfficiencyTester.Execute();
                            break;
                        case 6:
                            SubstringSearcher.Execute();
                            break;
                        case 7:
                            RegexValidator.Execute();
                            break;
                        case 8:
                            DateExtractor.Execute();
                            break;
                        case 9:
                            ComplexStringSplitter.Execute();
                            break;
                        case 10:
                            ListSorter.Execute();
                            break;
                        case 11:
                            WordFrequencyAnalyzer.Execute();
                            break;
                        case 12:
                            CollectionProcessor.Execute();
                            break;
                        case 13:
                            ImmutableCollectionDemo.Execute();
                            break;
                        case 14:
                            _14__MultiplicationTable.Execute();
                            break;
                        case 15:
                            _15_FromStringToDateTime.Execute();
                            break;
                        default:
                            Console.WriteLine("Некорректный номер задания.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                }
            }
        }
    }
}
