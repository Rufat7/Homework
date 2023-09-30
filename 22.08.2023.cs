#region task 1


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число от 1 до 100:");
        int number = int.Parse(Console.ReadLine());

        if (number < 1 || number > 100)
        {
            Console.WriteLine("Ошибка: число должно быть от 1 до 100");
        }
        else if (number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("Fizz Buzz");
        }
        else if (number % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (number % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(number);
        }
    }
}
#endregion

#region task 2 
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите четыре цифры:");
        int digit1 = int.Parse(Console.ReadLine());
        int digit2 = int.Parse(Console.ReadLine());
        int digit3 = int.Parse(Console.ReadLine());
        int digit4 = int.Parse(Console.ReadLine());

        int number = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;
        Console.WriteLine("Результат: " + number);
    }
}
#endregion

#region task 3
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Введите шестизначное число:");
        int number = int.Parse(Console.ReadLine());

        if (number < 100000 || number > 999999)
        {
            Console.WriteLine("Ошибка: число должно быть шестизначным");
        }
        else
        {
            Console.WriteLine("Введите номера разрядов для обмена цифр:");
            int digit1 = int.Parse(Console.ReadLine());
            int digit2 = int.Parse(Console.ReadLine());

            int[] digits = new int[6];
            for (int i = 5; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }

            int temp = digits[digit1 - 1];
            digits[digit1 - 1] = digits[digit2 - 1];
            digits[digit2 - 1] = temp;

            int result = 0;
            for (int i = 0; i < 6; i++)
            {
                result = result * 10 + digits[i];
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
#endregion


#region task 4
using System;

class Program
{
    static void Main()
    {
        int temperature = 0;
        while (temperature == 0)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Перевести из Фаренгейта в Цельсий");
            Console.WriteLine("2. Перевести из Цельсия в Фаренгейт");

            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.KeyChar == '1')
            {
                Console.Write("Введите температуру в Фаренгейтах: ");
                int fahrenheit = int.Parse(Console.ReadLine());
                int celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"Температура в Цельсиях: {celsius}");
                temperature = 1;
            }
            else if (key.KeyChar == '2')
            {
                Console.Write("Введите температуру в Цельсиях: ");
                int celsius = int.Parse(Console.ReadLine());
                int fahrenheit = celsius * 9 / 5 + 32;
                Console.WriteLine($"Температура в Фаренгейтах: {fahrenheit}");
                temperature = 1;
            }
        }
    }
}
#endregion

#region task 5
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }

        Console.WriteLine($"Четные числа в диапазоне от {firstNumber} до {secondNumber}:");
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
#endregion