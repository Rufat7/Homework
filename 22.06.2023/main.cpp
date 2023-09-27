

#include "header.h"

int main() {

    setlocale(LC_ALL, "Rus");
    Queue queue;

    queue.enqueue(10);
    queue.enqueue(20);
    queue.enqueue(30);

    cout << "Первый элемент:" << queue.getFront() << endl;

    queue.dequeue();
    queue.dequeue();
    queue.dequeue();
    queue.dequeue();

    return 0;
}