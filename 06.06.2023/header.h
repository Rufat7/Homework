

#ifndef UNTITLED7_HEADER_H
#define UNTITLED7_HEADER_H
#include <iostream>
#include <cstring>
using namespace std;

struct Node {
    int data;
    Node* next;
    Node* prev;
};

class DoublyLinkedList {
private:
    Node* head;
    Node* tail;
    int size;

public:
    DoublyLinkedList() {
        head = 0;
        tail = 0;
        size = 0;
    }


    void append(int data)
    {
        Node* node = new Node;
        node->data = data;
        node->next = 0;
        node->prev = tail;

        if (tail != 0) {
            tail->next = node;
        }
        else {
            head = node;
        }

        tail = node;
        size++;
    }


    void prepend(int data) {
        Node* newNode = new Node;
        newNode->data = data;
        newNode->next = head;
        newNode->prev = 0;

        if (head != 0) {
            head->prev = newNode;
        }
        else {
            tail = newNode;
        }

        head = newNode;
        size++;
    }


    void insert(int index, int data) {
        if (index < 0 || index > size) {
            cout << "Index out of range" << endl;
            return;
        }

        if (index == 0) {
            prepend(data);
            return;
        }

        if (index == size) {
            append(data);
            return;
        }

        Node* newNode = new Node;
        newNode->data = data;

        Node* current = head;
        for (int i = 0; i < index; i++) {
            current = current->next;
        }

        newNode->next = current;
        newNode->prev = current->prev;
        current->prev->next = newNode;
        current->prev = newNode;

        size++;
    }


    void pop() {
        if (tail == NULL) {
            cout << "List is empty" << endl;
            return;
        }

        Node* temp = tail;
        tail = tail->prev;

        if (tail != 0) {
            tail->next = 0;
        }
        else {
            head = 0;
        }

        delete temp;
        size--;
    }

    void remove(int index) {
        if (index < 0 || index >= size) {
            cout << "Index out of range" << endl;
            return;
        }

        if (index == 0) {
            Node* temp = head;
            head = head->next;

            if (head != 0) {
                head->prev = 0;
            }
            else {
                tail = 0;
            }

            delete temp;
            size--;
            return;
        }

        if (index == size - 1) {
            pop();
            return;
        }

        Node* current = head;
        for (int i = 0; i < index; i++) {
            current = current->next;
        }

        current->prev->next = current->next;
        current->next->prev = current->prev;

        delete current;
        size--;
    }


    void removeValue(int data) {
        Node* current = head;

        while (current != 0) {
            if (current->data == data) {
                if (current == head) {
                    remove(0);
                    return;
                }

                if (current == tail) {
                    pop();
                    return;
                }

                current->prev->next = current->next;
                current->next->prev = current->prev;

                delete current;
                size--;
                return;
            }

            current = current->next;
        }

        cout << "Value not found" << endl;
    }


    void printList() {
        Node* current = head;
        while (current != NULL) {
            cout << current->data << " ";
            current = current->next;
        }
        cout << endl;
    }
};

#endif
