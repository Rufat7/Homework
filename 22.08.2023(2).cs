4.
}
        }

        Console.WriteLine("Введите элементы второй матрицы:");

for (int i = 0; i < columns1; i++)
{
    for (int j = 0; j < columns2; j++)
    {
        Console.Write($"Элемент [{i}, {j}]: ");
        matrix2[i, j] = int.Parse(Console.ReadLine());
    }
}

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < columns2; j++)
    {
        for (int k = 0; k < columns1; k++)
        {
            result[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}

Console.WriteLine("Результат произведения матриц:");

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < columns2; j++)
    {
        Console.Write($"{result[i, j]} ");
    }
    Console.WriteLine();
}
    }
}

5.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите арифметическое выражение:");
        string expression = Console.ReadLine();

        try
        {
            int result = Calculate(expression);
            Console.WriteLine("Результат: " + result);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }

        Console.ReadLine();
    }

    static int Calculate(string expression)
    {
        int result = 0;
        char operation = '+';

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '+' || expression[i] == '-')
            {
                operation = expression[i];
            }
            else
            {
                int number = 0;
                while (i < expression.Length && char.IsDigit(expression[i]))
                {
                    number = number * 10 + (expression[i] - '0');
                    i++;
                }
                i--;

                if (operation == '+')
                {
                    result += number;
                }
                else if (operation == '-')
                {
                    result -= number;
                }
            }
        }

        return result;
    }
}
6.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        string result = CapitalizeSentences(text);
        Console.WriteLine("Результат: " + result);

        Console.ReadLine();
    }

    static string CapitalizeSentences(string text)
    {
        string[] sentences = text.Split('.', '!', '?');

        for (int i = 0; i < sentences.Length; i++)
        {
            string sentence = sentences[i].Trim();

            if (!string.IsNullOrEmpty(sentence))
            {
                char firstChar = char.ToUpper(sentence[0]);
                string restOfSentence = sentence.Substring(1);

                sentences[i] = firstChar + restOfSentence;
            }
        }

        return string.Join(". ", sentences);
    }
}

7.
using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string text = Console.ReadLine();

        Console.WriteLine("Введите недопустимые слова (через запятую):");
        string invalidWordsInput = Console.ReadLine();
        string[] invalidWords = invalidWordsInput.Split(',');

        int replacedCount = 0;
        string result = ReplaceInvalidWords(text, invalidWords, out replacedCount);

        Console.WriteLine("Результат: " + result);
        Console.WriteLine("Количество замен: " + replacedCount);

        Console.ReadLine();
    }

    static string ReplaceInvalidWords(string text, string[] invalidWords, out int replacedCount)
    {
        replacedCount = 0;
        string[] words = text.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            if (invalidWords.Contains(word.ToLower()))
            {
                text = text.Replace(word, new string('*', word.Length));
                replacedCount++;
            }
        }

        return text;
    }
}
