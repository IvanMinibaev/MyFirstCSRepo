using System;

     class Program
    {
        static void Main()
        {
            int celsius;
            string input;

            Console.WriteLine("Пожалуйста, введите температуру в градусах Цельсия");
            input = Console.ReadLine();
            while (! int.TryParse(input, out celsius))
            {
            Console.WriteLine("Ошибка ввода, попробуйте еще раз");
            input = Console.ReadLine();
            }

            Console.WriteLine($"{celsius}C = {celsius * 1.8 + 32}F");
            Console.ReadLine();
        }
    }