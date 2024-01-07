# Итоговая контрольная работа по основному блоку

## Задача
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:*

*[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]*

*[“1234”, “1567”, “-2”, “computer science”] → [“-2”]*

*[“Russia”, “Denmark”, “Kazan”] → []*

## Решение

**Создаем исходные данные из массивов строк**
```sh
string[] str1 = {"Hello", "2", "world", ":-)"};
string[] str2 = {"1234", "1567", "-2", "computer science"};
string[] str3 = {"Russia", "Denmark", "Kazan"};
```

**Создаем возвращающую массив строк с не более тремя символами функцию**
```sh
int size = 0;
    int[] check = new int[100];
    
    for (int i = 0; i < str.Length; i++) {
        if (str[i].Length <= 3) {
            check[size] = i;
            size++;
        }
    }

    string[] newStr = new string[size];
    for (int i = 0; i < size; i++) {
        newStr[i] = str[check[i]];
    }
    return newStr;
```
**Разбор функции**

Переменная для размера нового массива строк
```sh
int size = 0;
```
Массив целочисленных чисел для хранения индексов строк исходного массива у которых количество символов не более трех
```sh
int[] check = new int[100];
```
Цикл для определения количества строк массива с количеством символов не более трех и их фиксация в check
```sh
for (int i = 0; i < str.Length; i++) {
    if (str[i].Length <= 3) {
        check[size] = i;
        size++;
    }
}
```
Создание нового массива строк с размером равным size
```sh
string[] newStr = new string[size];
for (int i = 0; i < size; i++) {
    newStr[i] = str[check[i]];
}
```
Возвращение нового массива newStr
```sh
return newStr;
```
*Визуализация функции в виде блок-схемы*
![Icon](/scheme_func1.png)

**Создаем функцию для вывода на консоль массивов из строк**
```sh
void print(string[] str) {
    if (str.Length == 0) {
        Console.Write("[]");
        return;
    }
    Console.Write("[“");
    for (int i = 0; i < str.Length; i++) {
        if (i == (str.Length - 1)) Console.Write(str[i] + "”]"); else
        Console.Write(str[i] + "”, “");
    }
} 
```
*Визуализация функции в виде блок-схемы*
![Icon](/scheme_func2.png)
**Вызываем возвращающую массив строк с не более тремя символами функцию с исходными массивами в условии**
```sh
string[] newStr1 = transformation(str1);
string[] newStr2 = transformation(str2);
string[] newStr3 = transformation(str3);
```

**Выводим на консоль результаты**
```sh
print(str1);
Console.Write(" → ");
print(newStr1);
Console.Write("\n");

print(str2);
Console.Write(" → ");
print(newStr2);
Console.Write("\n");

print(str3);
Console.Write(" → ");
print(newStr3);
Console.Write("\n");
```
*Визуализация программы в виде блок-схемы*
![Icon](/scheme_main.png)