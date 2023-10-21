2.
using System;

class Device
{
    protected string name;

    public Device(string name)
    {
        this.name = name;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Устройство издает звук");
    }

    public void Show()
    {
        Console.WriteLine($"Название устройства: {name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine("Описание устройства");
    }
}

class Kettle : Device
{
    public Kettle(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Чайник свистит");
    }

    public override void Desc()
    {
        Console.WriteLine("Чайник - это бытовое устройство для кипячения воды");
    }
}

class Microwave : Device
{
    public Microwave(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Микроволновка издает звук");
    }

    public override void Desc()
    {
        Console.WriteLine("Микроволновка - это бытовое устройство для нагрева и приготовления пищи");
    }
}

class Car : Device
{
    public Car(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Автомобиль гудит");
    }

    public override void Desc()
    {
        Console.WriteLine("Автомобиль - это транспортное средство для перевозки людей и грузов");
    }
}

class Steamboat : Device
{
    public Steamboat(string name) : base(name)
    {
    }

    public override void Sound()
    {
        Console.WriteLine("Пароход издает звук");
    }

    public override void Desc()
    {
        Console.WriteLine("Пароход - это судно, приводимое в движение паровой машиной");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kettle kettle = new Kettle("Чайник");
        kettle.Show();
        kettle.Sound();
        kettle.Desc();

        Microwave microwave = new Microwave("Микроволновка");
        microwave.Show();
        microwave.Sound();
        microwave.Desc();

        Car car = new Car("Автомобиль");
        car.Show();
        car.Sound();
        car.Desc();

        Steamboat steamboat = new Steamboat("Пароход");
        steamboat.Show();
        steamboat.Sound();
        steamboat.Desc();

        Console.ReadLine();
    }
}

3.
using System;

class MusicalInstrument
{
    protected string name;

    public MusicalInstrument(string name)
    {
        this.name = name;
    }

    public virtual void Sound()
    {
        Console.WriteLine("Издает звук музыкального инструмента");
    }

    public void Show()
    {
        Console.WriteLine("Название музыкального инструмента: " + name);
    }

    public virtual void Desc()
    {
        Console.WriteLine("Описание музыкального инструмента");
    }

    public virtual void History()
    {
        Console.WriteLine("История создания музыкального инструмента");
    }
}

class Violin : MusicalInstrument
{
    public Violin(string name) : base(name) { }

    public override void Sound()
    {
        Console.WriteLine("Скрипка издает звук");
    }

    public override void Desc()
    {
        Console.WriteLine("Скрипка - струнный смычковый музыкальный инструмент");
    }

    public override void History()
    {
        Console.WriteLine("Скрипка была создана в 16 веке");
    }
}

class Trombone : MusicalInstrument
{
    public Trombone(string name) : base(name) { }

    public override void Sound()
    {
        Console.WriteLine("Тромбон издает звук");
    }

    public override void Desc()
    {
        Console.WriteLine("Тромбон - медный духовой музыкальный инструмент");
    }

    public override void History()
    {
        Console.WriteLine("Тромбон был создан в 15 веке");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele(string name) : base(name) { }

    public override void Sound()
    {
        Console.WriteLine("Укулеле издает звук");
    }

    public override void Desc()
    {
        Console.WriteLine("Укулеле - струнный щипковый музыкальный инструмент");
    }

    public override void History()
    {
        Console.WriteLine("Укулеле было создано в 19 веке на Гавайях");
    }
}

class Cello : MusicalInstrument
{
    public Cello(string name) : base(name) { }

    public override void Sound()
    {
        Console.WriteLine("Виолончель издает звук");
    }

    public override void Desc()
    {
        Console.WriteLine("Виолончель - струнный смычковый музыкальный инструмент большого размера");
    }

    public override void History()
    {
        Console.WriteLine("Виолончель была создана в 16 веке");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Violin violin = new Violin("Скрипка");
        violin.Show();
        violin.Sound();
        violin.Desc();
        violin.History();

        Console.WriteLine();

        Trombone trombone = new Trombone("Тромбон");
        trombone.Show();
        trombone.Sound();
        trombone.Desc();
        trombone.History();

        Console.WriteLine();

        Ukulele ukulele = new Ukulele("Укулеле");
        ukulele.Show();
        ukulele.Sound();
        ukulele.Desc();
        ukulele.History();

        Console.WriteLine();

        Cello cello = new Cello("Виолончель");
        cello.Show();
        cello.Sound();
        cello.Desc();
        cello.History();

        Console.ReadLine();
    }
}
4.
using System;

abstract class Worker
{
    protected string name;
    protected int age;

    public Worker(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public abstract void Print();
}

class President : Worker
{
    private string company;

    public President(string name, int age, string company) : base(name, age)
    {
        this.company = company;
    }

    public override void Print()
    {
        Console.WriteLine($"Президент {name}, возраст {age} лет, работает в компании {company}");
    }
}

class Security : Worker
{
    private string department;

    public Security(string name, int age, string department) : base(name, age)
    {
        this.department = department;
    }

    public override void Print()
    {
        Console.WriteLine($"Охранник {name}, возраст {age} лет, работает в отделе {department}");
    }
}

class Manager : Worker
{
    private string project;

    public Manager(string name, int age, string project) : base(name, age)
    {
        this.project = project;
    }

    public override void Print()
    {
        Console.WriteLine($"Менеджер {name}, возраст {age} лет, управляет проектом {project}");
    }
}

class Engineer : Worker
{
    private string specialization;

    public Engineer(string name, int age, string specialization) : base(name, age)
    {
        this.specialization = specialization;
    }

    public override void Print()
    {
        Console.WriteLine($"Инженер {name}, возраст {age} лет, специализируется на {specialization}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        President president = new President("Ровшан", 50, "Nike");
        president.Print();

        Security security = new Security("Эмиль", 25, "Безопасность");
        security.Print();

        Manager manager = new Manager("Али", 40, "Проект R");
        manager.Print();

        Engineer engineer = new Engineer("Анар", 35, "Программирование");
        engineer.Print();

        Console.ReadLine();
    }
}