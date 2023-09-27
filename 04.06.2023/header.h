

#ifndef UNTITLED6_HEADER_H
#define UNTITLED6_HEADER_H
#include <iostream>
using namespace std;

template<typename T>
class MyVector {
private:
    T* arr{};
    size_t length{};
    size_t capacity{};
public:
    MyVector(size_t capacity) {
        this->capacity = capacity;
    }

    MyVector(initializer_list<T> list) {
        this->capacity = list.size() * 2;
        this->length = list.size();
        this->arr = new T[this->capacity]{};

        for (auto i = list.begin(); i < list.end(); ++i) {
            this->arr[i - list.begin()] = *i;
        }
    }


    void append(const T& element) {
        if (this->length == this->capacity) {
            this->capacity *= 2;
            T* new_arr = new T[this->capacity]{};
            for (size_t i = 0; i < this->length; ++i) {
                new_arr[i] = this->arr[i];
            }
            delete[] this->arr;
            this->arr = new_arr;
        }
        this->arr[this->length] = element;
        this->length++;
    }

    void push_back(const T& element) {
        append(element);
    }

    void pop_back() {
        if (this->length > 0) {
            this->length--;
        }
    }

    void clear() {
        this->length = 0;
    }


    void insert(size_t index, const T& element) {
        if (index <= this->length) {
            if (this->length == this->capacity) {
                this->capacity *= 2;
                T* new_arr = new T[this->capacity]{};
                for (size_t i = 0; i < index; ++i) {
                    new_arr[i] = this->arr[i];
                }
                new_arr[index] = element;
                for (size_t i = index + 1; i <= this->length; ++i) {
                    new_arr[i] = this->arr[i - 1];
                }
                delete[] this->arr;
                this->arr = new_arr;
                this->length++;
            }
            else {
                for (size_t i = this->length; i > index; --i) {
                    this->arr[i] = this->arr[i - 1];
                }
                this->arr[index] = element;
                this->length++;
            }
        }
    }

    size_t getLength() const {
        return this->length;
    }

    friend ostream& operator<<(ostream& os, MyVector<T>& v) {
        for (size_t i = 0; i < v.length; ++i) {
            os << v.arr[i] << ' ';
        }
        return os;
    }

    T& operator[](size_t index) {
        if (index < this->length) {
            return this->arr[index];
        }
        else {
            cout << "Index out of range" << endl;
        }
    }
};
#endif