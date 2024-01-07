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