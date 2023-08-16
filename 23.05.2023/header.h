#ifndef UNTITLED2_HEADER_H
#define UNTITLED2_HEADER_H
#include <iostream>
#include <string>
#include <cstdint>

using namespace std;

class Student {
private:
    uint16_t age;
    uint16_t birthdate;
public:
    string name;
    string surname;
    string phone;
    string city;
    string country;
    string university;
    string university_city;
    string university_country;
    int group_number;

    Student() = default;

    Student(string name, string surname, string phone, string city, string country, string university, string university_city, string university_country, int group_number, uint16_t age, uint16_t birthdate) {
        this->name = name;
        this->surname = surname;
        this->phone = phone;
        this->city = city;
        this->country = country;
        this->university = university;
        this->university_city = university_city;
        this->group_number = group_number;

    }

    void setAge(uint16_t age) {
        if (age > 0 && age < 150)
            this->age = age;
    }
    uint16_t getAge() const {
        return this->age;
    }



    bool operator==(const Student& other) const {
        return this->name == other.name && this->surname == other.surname && this->phone == other.phone && this->city == other.city && this->country == other.country && this->university == other.university && this->university_city == other.university_city && this->university_country == other.university_country && this->group_number == other.group_number && this->birthdate == other.birthdate && this->age == other.age;
    }

    bool operator!=(const Student& other) const {
        return !(*this == other);
    }

    bool operator<(const Student& other) const {
        return this->age < other.age;
    }


    bool operator>(const Student& other) const {
        return this->age > other.age;
    }


    bool operator<=(const Student& other) const {
        return this->age <= other.age;
    }



    bool operator>=(const Student& other) const {
        return this->age >= other.age;
    }

    friend ostream& operator << (ostream& os, const Student& student) {
        os << student.name << " " << student.surname << " " << student.phone << " " << student.city << " " << student.country << " " << student.university << " " << student.university_city << " " << student.university_country << " " << student.group_number << " " << student.getAge();
        return os;
    }

    friend istream& operator >> (istream& is, Student& student) {
        cout << "Введите Имя: ";
        is >> student.name;

        cout << "Введите Фамилию: ";
        is >> student.surname;

        cout << "Введите Номер: ";
        is >> student.phone;

        cout << "Введите Город: ";
        is >> student.city;

        cout << "Введите Страну: ";
        is >> student.country;

        cout << "Введите Университет: ";
        is >> student.university;

        cout << "Введите Город Университета: ";
        is >> student.university_country;

        cout << "Введите Номер Группы: ";
        is >> student.group_number;

        cout << "Введите Год Рождения: ";
        is >> student.birthdate;

        cout << "Введите Возраст: ";
        is >> student.age;

        return is;
    }
};

#endif
