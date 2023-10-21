1.
class Program
{
    static void Main()
    {
        int Length = 4;
        char Symbol = '*';

        Draw(Length, Symbol);
    }

    public static void Draw(int Length, char Symbol)
    {
        for (int i = 0; i < Length; i++)
        {
            for (int j = 0; j < Length; j++)
            {
                Console.Write(Symbol);
            }
            Console.WriteLine();
        }
    }
}
2.
class Program
{
    static void Main()
    {
        int number = 1221;
        bool isPalindrome = IsPalindrome(number);

        if (isPalindrome)
        {
            Console.WriteLine($"{number} - палиндром");
        }
        else
        {
            Console.WriteLine($"{number} - не палиндром");
        }
    }

    public static bool IsPalindrome(int number)
    {
        int num1 = 0;
        int num2 = number;

        while (number > 0)
        {
            int digit = number % 10;
            num1 = num1 * 10 + digit;
            number = number / 10;
        }

        return num2 == num1;
    }

}


5.
using System;

class Journal
{
    private string name;
    private int year;
    private string description;
    private string phone;
    private string email;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetYear(int year)
    {
        this.year = year;
    }

    public int GetYear()
    {
        return year;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetPhone(string phone)
    {
        this.phone = phone;
    }

    public string GetPhone()
    {
        return phone;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }

    public void InputData()
    {
        Console.Write("Введите название журнала: ");
        name = Console.ReadLine();

        Console.Write("Введите год основания: ");
        year = int.Parse(Console.ReadLine());

        Console.Write("Введите описание журнала: ");
        description = Console.ReadLine();

        Console.Write("Введите контактный телефон: ");
        phone = Console.ReadLine();

        Console.Write("Введите контактный e-mail: ");
        email = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine("Название журнала: " + name);
        Console.WriteLine("Год основания: " + year);
        Console.WriteLine("Описание журнала: " + description);
        Console.WriteLine("Контактный телефон: " + phone);
        Console.WriteLine("Контактный e-mail: " + email);
    }
}

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        journal.InputData();
        Console.WriteLine("\nИнформация о журнале:");
        journal.DisplayData();
    }
}
6.
using System;

class Magazine
{
    private string name;
    private string address;
    private string description;
    private string phone;
    private string email;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public string GetAddress()
    {
        return address;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public string GetDescription()
    {
        return description;
    }

    public void SetPhone(string phone)
    {
        this.phone = phone;
    }

    public string GetPhone()
    {
        return phone;
    }

    public void SetEmail(string email)
    {
        this.email = email;
    }

    public string GetEmail()
    {
        return email;
    }

    public void InputData()
    {
        Console.Write("Введите название магазина: ");
        name = Console.ReadLine();

        Console.Write("Введите адрес магазина: ");
        address = Console.ReadLine();

        Console.Write("Введите описание профиля магазина: ");
        description = Console.ReadLine();

        Console.Write("Введите контактный телефон: ");
        phone = Console.ReadLine();

        Console.Write("Введите контактный e-mail: ");
        email = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine("Название магазина: " + name);
        Console.WriteLine("Адрес: " + address);
        Console.WriteLine("Описание профиля магазина: " + description);
        Console.WriteLine("Контактный телефон: " + phone);
        Console.WriteLine("Контактный e-mail: " + email);
    }
}

class Program
{
    static void Main()
    {
        Magazine journal = new Magazine();
        journal.InputData();
        Console.WriteLine("\nИнформация о магазине:");
        journal.DisplayData();
    }
}