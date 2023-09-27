#include "header.h"

using namespace std;



int main() {
    SystemKomp* num1 = new SystemKomp("Hp", "Pavilion Gaming", "777777");
    Processor* num2 = new Processor("Intel", "CORE i7", "111111", 12, 4, 4);


    num1->print();
    num2->print();

    return 0;
}