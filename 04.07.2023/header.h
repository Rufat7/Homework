

#ifndef UNTITLED13_HEADER_H
#define UNTITLED13_HEADER_H
#include <iostream>
#include <fstream>

using namespace std;

struct Bus {
    int number;
    string driverName;
    int routeNumber;
    int seatCount;
    Bus* left;
    Bus* right;

    Bus(int number, string driverName, int routeNumber, int seatCount) {
        this->number = number;
        this->driverName = driverName;
        this->routeNumber = routeNumber;
        this->seatCount = seatCount;
        left = nullptr;
        right = nullptr;
    }
};

class BusPark {
private:
    Bus* root;

    Bus* insert(Bus* bus, int number, string driverName,int routeNumber, int seatCount) {
        if (bus == nullptr) {
            return new Bus(number, driverName, routeNumber, seatCount);
        }

        if (number < bus->number) {
            bus->left = insert(bus->left, number, driverName, routeNumber, seatCount);
        }
        else {
            bus->right = insert(bus->right, number, driverName, routeNumber,  seatCount);
        }

        return bus;
    }

    Bus* search(Bus* bus, int number) {
        if (bus == nullptr || bus->number == number) {
            return bus;
        }

        if (number < bus->number) {
            return search(bus->left, number);
        }
        else {
            return search(bus->right, number);
        }
    }

    void printBusInfo(Bus* bus) {
        cout << "Номер автобуса: " << bus->number << endl;
        cout << "Имя Водителя: " << bus->driverName << endl;
        cout << "номер маршрута: " << bus->routeNumber << endl;
        cout << "Количество мест : " << bus->seatCount << endl;
    }

    void inorderTraversal(Bus* bus, std::ofstream& file) {
        if (bus != nullptr) {
            inorderTraversal(bus->left, file);
            file << "Номер Автобуса: " << bus->number << endl;
            file << "Имя Водителя: " << bus->driverName << endl;
            file << "Номер маршрута: " << bus->routeNumber << endl;
            file << "Количестов Мест: " << bus->seatCount << endl;
            file << endl;
            inorderTraversal(bus->right, file);
        }
    }

public:
    BusPark() {
        root = nullptr;
    }

    void addBus(int number, string driverName, int routeNumber, int seatCount) {
        root = insert(root, number, driverName, routeNumber, seatCount);
    }

    void searchBus(int number) {
        Bus* bus = search( root, number);
        if (bus != nullptr) {
            printBusInfo(bus);
        }
        else {
            cout << "Автобус не Найден." << endl;
        }
    }

    void saveToFile(string fileName) {
        ofstream file(fileName);
        inorderTraversal(root, file);
        file.close();
    }
};

#endif
