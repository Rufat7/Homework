#ifndef UNTITLED_HEADER_H
#define UNTITLED_HEADER_H
#include <iostream>

using namespace std;

class Machine {
public:
    virtual void drive() = 0;
    virtual void park() = 0;
    virtual void Work() = 0;

};

class Sedan : public Machine {
public:
    void drive() override {
        cout << "Седан едет по дороге\n";
    }

    void park() override {
        cout << "Седан паркуется на стоянке\n";
    }

    void Work() override {
        cout << "Седан выполняет работу\n";
    }
};

class Bus : public Machine {
public:
    void drive() override {
        cout << "Автобус перевозит пассажиров\n";
    }

    void park() override {
        cout << "Автобус останавливается на автобусной остановке\n";
    }

    void Work() override {
        cout << "Автобус выполняет работу\n";
    }
};

class Truck : public Machine {
public:
    void drive() override {
        cout << "Грузовик перевозит груз\n";
    }

    void park() override {
        cout << "Грузовик паркуется на складе\n";
    }

    void Work() override {
        cout << "Грузовик выполняет работу\n";
    }
};

class SportsCar : public Machine {
public:
    void drive() override {
        cout << "BMW обьезжает Мерседес по трассе \n";
    }

    void park() override {
        cout << "У Мерседеса загорелся чек.Паркуется на специальной стоянке\n";
    }

    void Work() override {
        cout << "BMW выполняет работу\n";
    }
};
#endif
