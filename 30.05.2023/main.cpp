

#include "header.h"

int main() {
    setlocale(LC_ALL, "Rus");
    Classroom classroom;

    Student num1;
    cin >> num1;
    Student num2;
    cin >> num2;
    Student num3;
    cin >> num3;
    Student num4;
    cin >> num4;

    classroom.add(num1);
    classroom.add(num2);
    classroom.add(num3);
    classroom.add(num4);
    cout << classroom;

    return 0;
}