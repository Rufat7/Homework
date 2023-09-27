#ifndef UNTITLED4_HEADER_H
#define UNTITLED4_HEADER_H
#include <iostream>
#include <string>

using namespace std;

class SystemKomp  {
protected:
    string make{};
    string model{};
    string serialNumber{};


public:
    SystemKomp(string make, string model, string serialNumber) {
        this->make = make;
        this->model = model;
        this->serialNumber = serialNumber;

    }
    void print() const {
        cout << "System Komp: " << make << " " << model << ", Serial Number: " << serialNumber << endl;


    }
};

struct Processor : public SystemKomp {
private:
    int cores;
    int clock_frequency;
    int cache;

public:
    Processor(string make, string model, string serialNumber, int cores, int clock_frequency, int cache) : SystemKomp(make, model, serialNumber) {
        this->cores = cores;
        this->clock_frequency = clock_frequency;
        this->cache = cache;

    }

    void print() const {
        cout << "Processor: " << make << " " << model << ", Serial Number: " << serialNumber
             << ", Cores: " << cores << ", clock frequency: " << clock_frequency << ", Cache: " << cache << endl;
    }
};

#endif
