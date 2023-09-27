
#ifndef UNTITLED8_HEADER_H
#define UNTITLED8_HEADER_H
#include <iostream>
#include <string>
using namespace std;

class SystemKomp {
protected:
    string make;
    string model;
    string serialNumber;
    int ram;

public:
    SystemKomp(string make, string model, string serialNumber, int ram) {
        this->make = make;
        this->model = model;
        this->serialNumber = serialNumber;
        this->ram = ram;
    }
    void print() const {
        cout << "System Komp: " << make << " " << model << ", Serial Number: " << serialNumber << ", Ram:" << ram << endl;


    }
};
class CPU {
private:
    string model;
public:
    CPU(string) : model() {}
    string getModel() {
        return model;
    }
};

class RAM {
private:
    int size;
public:
    RAM(int) : size() {}
    int getSize() {
        return size;
    }
};

class Computer {
private:
    CPU cpu;
    RAM* ram;
    int numofrum;
public:
    Computer(string cpuModel, RAM* r, int num) : cpu(cpuModel), ram(r), numofrum(num) {}
    void printSpecs() {
        cout << "CPU: " << cpu.getModel() << endl;
        for (int i = 0; i < numofrum; i++) {
            cout << "RAM " << i + 1 << " size: " << ram[i].getSize() << " GB" << endl;
        }
    }
};

#endif
