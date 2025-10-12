using System;
using System.Text;

class Program
{
    static void Main()
    {
        string text;
        char[] splitters = { '.', ' ', ',', '!', '?' };
        string oftenWord;
        int wordNumber = 0;
        int sentenceNumber = 0;
        float letterNumber = 0.0F;

        Console.WriteLine("Привет! Введи мне любой текст, а я постараюсь его проанализировать");
        text = Console.ReadLine();
        text = text + ' ';
        for(int i = 0; i < text.Length - 1; i++ )
        {
            if (Char.IsLetter(text[i]))
            { 
                letterNumber += 1F;
                if (!Char.IsLetter(text[i + 1]))
                    wordNumber++;
                if ((text[i + 1] == '.') || (text[i + 1] == '!') || (text[i + 1] == '?'))
                    sentenceNumber++;

            }
        }

        Console.WriteLine($"Количество слов:{wordNumber}\nКоличество предложений:{sentenceNumber}\nСредняя ддина слова:{letterNumber/wordNumber}");
        
        string output = "-";
        int same = 0;
        int max = 0;

        string[] words =(text.ToLower()).Split(splitters);
        Array.Sort(words);
        for(int i = 0; i < words.Length-1; i++)
        {
            if ((words[i] == words[i + 1]) && (words[i].Length > 0))
                same++;
            else
            {
                if (same > max)
                {
                    max = same;
                    output = words[i];
                }
                same = 0;
            }    
                
        }
    
        Console.WriteLine($"Одно из самых часто встречающихся слов - это \"{output}\"");
    }
}