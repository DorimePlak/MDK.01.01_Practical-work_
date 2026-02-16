using System;
namespace Практическая_работа__1._1
{
    class Program_3
    {
        static void Main()
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double result = Math.Pow((x + 1) / (x - 1), x) + (18 * x * Math.Pow(y, 2));
            Console.WriteLine($"Для x = {x} и y = {y} ");
            Console.WriteLine($"Результат = {result:f2}");
        }
    }
} //Задание номер 3