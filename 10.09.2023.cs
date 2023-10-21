1.
using System;

public interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

public class MyArray : ICalc
{
    private int[] array;

    public MyArray(int[] array)
    {
        this.array = array;
    }

    public int Less(int valueToCompare)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num < valueToCompare)
            {
                count++;
            }
        }
        return count;
    }

    public int Greater(int valueToCompare)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num > valueToCompare)
            {
                count++;
            }
        }
        return count;
    }
}

public class Program
{
    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        MyArray myArray = new MyArray(numbers);

        int lessCount = myArray.Less(5);
        Console.WriteLine("Меньше 5: " + lessCount);

        int greaterCount = myArray.Greater(4);
        Console.WriteLine("Больше 5: " + greaterCount);
    }
}

3.

public interface ICalc
{
    int Less(int num1);
    int Greater(int num2);
}

public interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}

public class Array : ICalc, IOutput2
{
    public int[] _num3;

    public Array(int[] array)
    {
        this._num3 = array;
    }

    public int Less(int num1)
    {
        var count = 0;
        foreach (var num in _num3)
        {
            if (num < num1)
            {
                count++;
            }
        }
        return count;
    }

    public int Greater(int num2)
    {
        var count = 0;
        foreach (var num in _num3)
        {
            if (num > num2)
            {
                count++;
            }
        }
        return count;
    }

    public void ShowEven()
    {
        Console.WriteLine("Четные Цифры:");
        foreach (var num in _num3)
        {
            if (num % 2 == 0)
            {
                Console.Write($"{num} ");
            }
        }
        Console.WriteLine();
    }

    public void ShowOdd()
    {
        Console.WriteLine("Нечетные Цифры:");
        foreach (var num in _num3)
        {
            if (num % 2 != 0)
            {
                Console.Write($"{num} ");
            }
        }
        Console.WriteLine();
    }

}
public class Program
{
    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 3, 2, 1, 10, 8, 6 };
        Array calculator = new(numbers);

        int less = calculator.Less(5);
        int greater = calculator.Greater(5);

        Console.WriteLine($"Количество элементов менее 5: {less}");
        Console.WriteLine($"Количество элементов более 5: {greater}");

        calculator.ShowEven();
        calculator.ShowOdd();
    }
}


