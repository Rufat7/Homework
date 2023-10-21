using System;

Calculator calculator = new Calculator();

MathOperation addOperation = calculator.Add;
MathOperation subtractOperation = calculator.Subtract;
MathOperation multiplyOperation = calculator.Multiply;
MathOperation divideOperation = calculator.Divide;

double num1 = 16;
double num2 = 8;

double result = addOperation(num1, num2);
Console.WriteLine($"Сложение: {num1} + {num2} = {result}");

result = subtractOperation(num1, num2);
Console.WriteLine($"Вычитание: {num1} - {num2} = {result}");

result = multiplyOperation(num1, num2);
Console.WriteLine($"Умножение: {num1} * {num2} = {result}");

result = divideOperation(num1, num2);
Console.WriteLine($"Деление: {num1} / {num2} = {result}");

result = divideOperation(num1, 0);
Console.WriteLine($"Разделение на 0: {num1} / 0 = {result}");

delegate double MathOperation(double num1, double num2);

class Calculator
{
    public double Add(double num1, double num2)
    {
        return num1 + num2;
    }

    public double Subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    public double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    public double Divide(double num1, double num2)
    {
        if (num2 != 0)
        {
            return num1 / num2;
        }
        else
        {
            Console.WriteLine("Невозможно разделить на ноль");
            return 0;
        }
    }
}

