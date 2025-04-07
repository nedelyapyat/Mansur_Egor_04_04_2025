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
                            SubstringSearcher.Execute();
                            break;
                        case 5:
                            StringProcessor.Execute();
                            break;
                        case 6:
                            StringEfficiencyTester.Execute();
                            break;
                        case 7:
                            SubstringSearcher.Execute();
                            break;
                        case 8:
                            RegexValidator.Execute();
                            break;
                        case 9:
                            DateExtractor.Execute();
                            break;
                        case 10:
                            ComplexStringSplitter.Execute();
                            break;
                        case 11:
                            ListSorter.Execute();
                            break;
                        case 12:
                            WordFrequencyAnalyzer.Execute();
                            break;
                        case 13:
                            CollectionProcessor.Execute();
                            break;
                        case 14:
                            ImmutableCollectionDemo.Execute();
                            break;
                        case 15:
                            IndexRangeDemo.Execute();
                            break;
                        case 16:
                            RangeManipulationDemo.Execute();
                            break;
                        case 17:
                            UriParserDemo.Execute();
                            break;
                        case 18:
                            NetworkCheckDemo.Execute();
                            break;
                        case 19:
                            AttributeReader.Execute();
                            break;
                        case 20:
                            LocalizationDemo.Execute();
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
