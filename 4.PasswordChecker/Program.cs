using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать!\nЭто абсолютно точно не мошенническая программа проверки паролей.\nПожалуйста, введите пароли от всех ваших аккаунтов, а мы проверим, насколько они безопасны :)");
        string password;
        bool noNumber;
        bool noLetter;
        bool noSign;
        bool perfect;
        password = Console.ReadLine();
        while (password != "exit")
        {
            noNumber = true;
            noLetter = true;
            noSign = true;
            perfect = true;

            if (password.Length < 8)
            {
                Console.WriteLine("Ваш пароль слишком короткий");
                perfect = false;
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsNumber(password[i]))
                    noNumber = false;
                else
                    if (Char.IsUpper(password[i]))
                    noLetter = false;
                else
                    if (!Char.IsLetter(password[i]))
                    noSign = false;
            }

            if (noNumber)
                Console.WriteLine("В пароле нет ни одной цифры");
            if (noLetter)
                Console.WriteLine("В пароле нет ни одной заглавной буквы");
            if (noSign)
                Console.WriteLine("В пароле нет ни одного специального символа");
            if ((!noSign) && (!noLetter) && (!noNumber) && (perfect))
                Console.WriteLine("У Вас надежный пороль!\n (Напишите exit вместо пароля если хотите выйти)");
            
            password = Console.ReadLine();
        }
    }
}