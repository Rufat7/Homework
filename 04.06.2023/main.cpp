

#include "header.h"

int main() {
    MyVector<int> v1 = { 1,6,7,10,11 };
    cout << v1 << endl;

    v1.push_back(6);
    v1.pop_back();
    cout << v1 << endl;

    v1.insert(2, 12);
    cout << v1 << endl;

    MyVector<int> v2 = { 2,3,8,9,12 };
    v1 = v2;
    cout << v1 << endl;

    v1.clear();
    cout << v1 << endl;

    return 0;
}