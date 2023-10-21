1.
using System;

class Journal
{
    private int Num1;
    private int v;

    public Journal(int v)
    {
        this.v = v;
    }

    public int Num2
    {
        get { return Num1; }
        set { Num1 = value; }
    }

    public static Journal operator +(Journal journal, int increment)
    {
        journal.Num2 += increment;
        return journal;
    }

    public static Journal operator -(Journal journal, int decrement)
    {
        journal.Num2 -= decrement;
        return journal;
    }

    public static bool operator ==(Journal journal1, Journal journal2)
    {
        return journal1.Num2 == journal2.Num2;
    }

    public static bool operator !=(Journal journal1, Journal journal2)
    {
        return journal1.Num2 != journal2.Num2;
    }

    public static bool operator >(Journal journal1, Journal journal2)
    {
        return journal1.Num2 > journal2.Num2;
    }

    public static bool operator <(Journal journal1, Journal journal2)
    {
        return journal1.Num2 < journal2.Num2;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Journal other = (Journal)obj;
        return Num2 == other.Num2;
    }

    public override int GetHashCode()
    {
        return Num2.GetHashCode();
    }
}
class Program
{
    static void Main()
    {
        Journal journal1 = new Journal(10);
        Journal journal2 = new Journal(5);


        journal1 += 3;
        journal2 -= 2;

        bool Equal = journal1 == journal2;
        bool NotEqual = journal1 != journal2;
        bool isLess = journal1 < journal2;
        bool isGreater = journal1 > journal2;

        Console.WriteLine($"Журнал 1: {journal1.Num2} сотрудники");
        Console.WriteLine($"Журнал 2: {journal2.Num2} сотрудники");
        Console.WriteLine($"Равны: {Equal}");
        Console.WriteLine($"Не Равны: {NotEqual}");
        Console.WriteLine($"Меньше: {isLess}");
        Console.WriteLine($"Больше: {isGreater}");
    }
}

2.
using System;
class Shop1
{
    private double num1;
    private double num2;

    public Shop1(double v)
    {
        this.num2 = v;
    }

    public double Area
    {
        get { return num1; }
        set { num1 = value; }
    }

    public static Shop1 operator +(Shop1 shop, double increment)
    {
        shop.Area += increment;
        return shop;
    }

    public static Shop1 operator -(Shop1 shop, double decrement)
    {
        shop.Area -= decrement;
        return shop;
    }

    public static bool operator ==(Shop1 shop1, Shop1 shop2)
    {
        return shop1.Area == shop2.Area;
    }

    public static bool operator !=(Shop1 shop1, Shop1 shop2)
    {
        return shop1.Area != shop2.Area;
    }

    public static bool operator >(Shop1 shop1, Shop1 shop2)
    {
        return shop1.Area > shop2.Area;
    }

    public static bool operator <(Shop1 shop1, Shop1 shop2)
    {
        return shop1.Area < shop2.Area;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Shop1 other = (Shop1)obj;
        return Area == other.Area;
    }

    public override int GetHashCode()
    {
        return Area.GetHashCode();
    }
}
class Program
{
    static void Main()
    {
        Shop1 store1 = new Shop1(1000.0);
        Shop1 store2 = new Shop1(800.0);


        store1 += 200.0;
        store2 -= 50.0;

        bool Equal = store1 == store2;
        bool NotEqual = store1 != store2;
        bool isLess = store1 < store2;
        bool isGreater = store1 > store2;

        Console.WriteLine(store1);
        Console.WriteLine(store2);
        Console.WriteLine($"Меньше: {Equal}");
        Console.WriteLine($"Не равны: {NotEqual}");
        Console.WriteLine($"Меньше: {isLess}");
        Console.WriteLine($"Лучше: {isGreater}");
    }
}

