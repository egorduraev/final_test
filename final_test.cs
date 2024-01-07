string[] transformation(string[] str) {
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
}

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

string[] str1 = {"Hello", "2", "world", ":-)"};
string[] str2 = {"1234", "1567", "-2", "computer science"};
string[] str3 = {"Russia", "Denmark", "Kazan"};

string[] newStr1 = transformation(str1);
string[] newStr2 = transformation(str2);
string[] newStr3 = transformation(str3);

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