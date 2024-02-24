// Пользователь с клавиатуры вводит некоторый текст. Приложение должно
// изменять регистр первой буквы каждого предложения на букву в верхнем регистре.
// Например, если пользователь ввёл: «today is a good day for walking. i will try to walk near the sea».
// Результат работы приложения: «Today is a good day for walking. I will try to walk near the sea».

using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        string result = ChangeSentenceCase(input);
        Console.WriteLine("Результат работы приложения:");
        Console.WriteLine(result);
    }

    static string ChangeSentenceCase(string input)
    {
        string pattern = @"(?<=[.!?])";
        string[] sentences = Regex.Split(input, pattern);

        for (int i = 0; i < sentences.Length; i++)
        {
            string sentence = sentences[i].Trim();
            if (!string.IsNullOrEmpty(sentence))
            {
                char firstChar = sentence[0];
                if (char.IsLower(firstChar))
                {
                    sentence = sentence.Substring(0, 1).ToUpper() + sentence.Substring(1);
                }
                sentences[i] = sentence;
            }
        }

        return string.Join(" ", sentences);
    }
}