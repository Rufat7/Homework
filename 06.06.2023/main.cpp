
#include "header.h"

int main() {
    DoublyLinkedList list;

    list.append(1);
    list.append(2);
    list.append(3);
    list.prepend(0);
    list.insert(2, 4);
    list.printList();

    list.pop();
    list.remove(1);
    list.removeValue(2);
    list.printList();

    return 0;
}