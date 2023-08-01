#include "header.h"

int main() {
    setlocale(LC_ALL, "Rus");
    Machine* sedan = new Sedan();
    sedan->drive();
    sedan->park();
    sedan->Work();

    Machine* bus = new Bus();
    bus->drive();
    bus->park();
    bus->Work();

    Machine* truck = new Truck();
    truck->drive();
    truck->park();
    truck->Work();

    Machine* sportsCar = new SportsCar();
    sportsCar->drive();
    sportsCar->park();
    sportsCar->Work();

    return 0;
}
