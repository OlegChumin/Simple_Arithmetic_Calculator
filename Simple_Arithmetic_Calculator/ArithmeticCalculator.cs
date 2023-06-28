using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Arithmetic_Calculator
{
    internal class ArithmeticCalculator
    {
        static void Main()
        {
            Console.WriteLine("Простой арифметический калькулятор");
            DataFromConsole data = new DataFromConsole();
            getData(data);
            Console.WriteLine($"Результат: {calculate(data)}");
        }

        class DataFromConsole
        {
            public double number_1 { get; set; }
            public char operation { get; set; }
            public double number_2 { get; set; }

        }

        static DataFromConsole getData(DataFromConsole data)
        {

            Console.WriteLine("Введите первое число: ");

            data.number_1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите операцию (+, -, *, /): ");
            data.operation = char.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            data.number_2 = double.Parse(Console.ReadLine());

            return data;
        }

        static double calculate(DataFromConsole data)
        {
            double result = 0;

            switch (data.operation)
            {
                case '+':
                    result = data.number_1 + data.number_2;
                    break;
                case '-':
                    result = data.number_1 - data.number_2;
                    break;
                case '*':
                    result = data.number_1 * data.number_2;
                    break;
                case '/':
                    result = data.number_1 / data.number_2;
                    break;
                default:
                    Console.WriteLine("Операция не распознана");
                    break;
            }

            return result;
        }
    }
}
