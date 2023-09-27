
#include "header.h"

int main() {
    RAM r1(8);
    RAM r2(16);
    RAM rams[] = { r1, r2 };
    Computer pc("Intel i7", rams, 2);
    pc.printSpecs();

    return 0;
}