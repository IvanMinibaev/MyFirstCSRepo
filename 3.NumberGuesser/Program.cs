using System;

class Program
{
    static void Main()
    {
        var rand = new Random();
        int answer = rand.Next(10) + 1;
        string input;
        int guess;
        bool end = false;

        Console.WriteLine("Привет! я загадал число от 1 до 10. Спорим, что ты его не отгадаешь?");
        while (!end)
        {
            input = Console.ReadLine();
            while (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Неверный ввод. Попробуй снова.");
                input = Console.ReadLine();
            }

            if (guess < answer)
                Console.WriteLine("Мое число больше");
            if (guess > answer)
                Console.WriteLine("Мое число меньше");
            if (guess == answer)
            {
                Console.WriteLine("Угадал! Просто повезло >:(");
                end = true;
            }
        }
    }
}