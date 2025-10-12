using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать!\nЭто абсолютно точно не мошенническая программа проверки паролей.\nПожалуйста, введите пароли от всех ваших аккаунтов, а мы проверим, насколько они безопасны :)");
        string password;
        bool nonumber;
        bool noletter;
        bool nosign;
        bool perfect;
        password = Console.ReadLine();
        while (password != "exit")
        {
            nonumber = true;
            noletter = true;
            nosign = true;
            perfect = true;

            if (password.Length < 8)
            {
                Console.WriteLine("Ваш пароль слишком короткий");
                perfect = false;
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsNumber(password[i]))
                    nonumber = false;
                else
                    if (Char.IsUpper(password[i]))
                    noletter = false;
                else
                    if (!Char.IsLetter(password[i]))
                    nosign = false;
            }

            if (nonumber)
                Console.WriteLine("В пароле нет ни одной цифры");
            if (noletter)
                Console.WriteLine("В пароле нет ни одной заглавной буквы");
            if (nosign)
                Console.WriteLine("В пароле нет ни одного специального символа");
            if ((!nosign) && (!noletter) && (!nonumber) && (perfect))
                Console.WriteLine("У Вас надежный пороль!\n (Напишите exit вместо пароля если хотите выйти)");
            
            password = Console.ReadLine();
        }
    }
}