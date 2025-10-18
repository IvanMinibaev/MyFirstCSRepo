using System;

class Program
{
    static void Main()
    {
        string input;
        int number = 1;
        int sum = 0;
        Console.WriteLine("Привет! Введи неколько чисел через enter, а я буду считать их сумму до тех пор, пока ты не введешь ноль");
        while (number != 0)
        {
            input = Console.ReadLine();
            while (!int.TryParse(input, out number))
            {
                Console.WriteLine("Ошибка ввода, попробуй снова");
                input = Console.ReadLine();
            }
            if (number != 0)
            {
                sum += number;
                Console.WriteLine($"Пока что сумма равна {sum}");
            }
        }
        Console.WriteLine($"Всего я насчитал {sum}. Пока - пока");
    }
}