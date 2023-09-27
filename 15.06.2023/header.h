
#ifndef UNTITLED9_HEADER_H
#define UNTITLED9_HEADER_H
#include <iostream>
#include <string>

using namespace std;

class Computer {
public:
    Computer(const string& name, int ram, int cache) : name(name), ram(ram), cache(cache) {}


    Computer(const Computer& other) : name(other.name), ram(other.ram), cache(other.cache) {}

    void printInfo() {
        cout << "Name: " << name << endl;
        cout << "RAM: " << ram << "GB" << endl;
        cout << "Cache: " << cache << "GB" << endl;
    }

private:
    string name;
    int ram;
    int cache;
};

#endif
