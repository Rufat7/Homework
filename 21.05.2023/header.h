#ifndef UNTITLED1_HEADER_H
#define UNTITLED1_HEADER_H
#include <iostream>
using namespace std;
class Fraction {
public:
    Fraction(int numerator = 0, int denominator = 1) : m_numerator(numerator), m_denominator(denominator) {}

    void set(int numerator, int denominator) {
        m_numerator = numerator;
        m_denominator = denominator;
    }


    void print() const {
        cout << m_numerator << "/" << m_denominator;
    }

    Fraction operator + (const Fraction& other) const {
        int new_numerator = m_numerator * other.m_denominator + m_denominator * other.m_numerator;
        int new_denominator = m_denominator * other.m_denominator;
        return Fraction(new_numerator, new_denominator);
    }


    Fraction operator- (const Fraction& other) const {
        int new_numerator = m_numerator * other.m_denominator - m_denominator * other.m_numerator;
        int new_denominator = m_denominator * other.m_denominator;
        return Fraction(new_numerator, new_denominator);
    }


    Fraction operator* (const Fraction& other) const {
        int new_numerator = m_numerator * other.m_numerator;
        int new_denominator = m_denominator * other.m_denominator;
        return Fraction(new_numerator, new_denominator);
    }


    Fraction operator/ (const Fraction& other) const {
        int new_numerator = m_numerator * other.m_denominator;
        int new_denominator = m_denominator * other.m_numerator;
        return Fraction(new_numerator, new_denominator);
    }

private:
    int m_numerator;
    int m_denominator;
};
#endif
