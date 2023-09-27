
#include "header.h"

int main() {
    setlocale(LC_ALL, "Rus");
    Node* root = nullptr;
    root = insertNode(root, 50);
    root = insertNode(root, 30);
    root = insertNode(root, 20);
    root = insertNode(root, 40);
    root = insertNode(root, 70);
    root = insertNode(root, 60);
    root = insertNode(root, 80);

    cout << "Исходное дерево: ";
    inorder(root);

    int valueToDelete = 20;
    root = deleteNode(root, valueToDelete);
    cout << "\nДерево после удаления элемента " << valueToDelete  << endl;
    inorder(root);

    int valueToEdit = 40;
    int newValue = 45;
    root = deleteNode(root, valueToEdit);
    root = insertNode(root, newValue);
    cout << "\nДерево после редактирования элемента " << valueToEdit << " на " << newValue << ": ";
    inorder(root);

    return 0;
}
