
#include "header.h"

int main() {
    setlocale(LC_ALL, "Rus");
    BusPark busPark;
    int choice;
    int number;
    string driverName;
    int routeNumber;
    int seatCount;
    string fileName;

    do {
        cout << "1. Добавить Автобус" << endl;
        cout << "2. Поиск Автобуса" << endl;
        cout << "3. Сохранить Файл" << endl;
        cout << "4. Выйти" << endl;
        cout << "Выберите Номер: ";
        cin >> choice;

        switch (choice) {
            case 1:
                cout << "Введите Номер Автобуса: ";
                cin >> number;
                cout << "Введите Имя Водителя: ";
                cin >> driverName;
                cout << "Введите Номер маршрута: ";
                cin >> routeNumber;
                cout << "Введите Количество Мест: ";
                cin >> seatCount;
                busPark.addBus(number, driverName, routeNumber, seatCount);
                break;
            case 2:
                cout << "Введите поиск по номеру автобуса: ";
                cin >> number;
                busPark.searchBus(number);
                break;
            case 3:
                cout << "Введите имя файла для сохранения: ";
                cin >> fileName;
                busPark.saveToFile(fileName);
                cout << "Данные сохраняются в файл." << endl;
                break;
            case 4:
                cout << "Выход..." << endl;
                break;
            default:
                cout << "Неверный Выбор.Выберите Снова" << endl;
                break;
        }
    } while (choice != 4);

    return 0;
}
