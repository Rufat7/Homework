#include "header.h"

int main() {
    Fraction num1(1, 2);
    Fraction num2(1, 3);

    Fraction sum = num1 + num2;
    Fraction difference = num1 - num2;
    Fraction multiplication = num1 * num2;
    Fraction division = num1 / num2;

    cout << "num1 = ";
    num1.print();
    cout << "\n";

    cout << "num2 = ";
    num2.print();
    cout << "\n";

    cout << "num1 + num2 = ";
    sum.print();
    cout << "\n";

    cout << "num1 - num2 = ";
    difference.print();
    cout << "\n";

    cout << "num1 * num2 = ";
    multiplication.print();
    cout << "\n";

    cout << "num1 / num2 = ";
    division.print();
    cout << "\n";

    return 0;
}