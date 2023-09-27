

#ifndef UNTITLED10_HEADER_H
#define UNTITLED10_HEADER_H
#include <iostream>
using namespace std;


struct Node {
    int data;
    Node* next;
};

class Queue {
private:
    Node* begin;
    Node* end;

public:

    Queue() {
        begin = nullptr;
        end = nullptr;
    }


    void enqueue(int value) {
        Node* newNode = new Node;
        newNode->data = value;
        newNode->next = nullptr;

        if (begin == nullptr) {
            begin = end = newNode;
        }
        else {
            end->next = newNode;
            end = newNode;
        }

        cout << "Элемент " << value << " добавлен в очередь." << endl;
    }

    void dequeue() {
        if (begin == nullptr) {
            cout << "Очередь пуста. Невозможно удалить элемент." << endl;
            return;
        }

        Node* temp = begin;
        begin = begin->next;

        if (begin == nullptr) {
            end = nullptr;
        }

        cout << "Элемент " << temp->data << " удален из очереди." << endl;
        delete temp;
    }
    int getFront() {
        if (begin == nullptr) {
            cout << "Очередь пуста." << endl;
            return -1;
        }

        return begin->data;
    }


};
#endif
