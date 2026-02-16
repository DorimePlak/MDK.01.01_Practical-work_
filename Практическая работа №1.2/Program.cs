using System;
namespace Практическая_работа__1._2
{
    class Program_7
    {
        static void Main()
        {
            Console.Write("Введите трёхзначное целое число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int temp = number;
            int sum = 0;

            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            int digit1 = number / 100;
            int digit2 = (number / 10) % 10;
            int digit3 = number % 10;
            Console.WriteLine($"Сумма цифр числа: {digit1} + {digit2} + {digit3} = {sum}");
        }
    }
} //Задание номер 7