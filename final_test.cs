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