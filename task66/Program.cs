
Console.WriteLine("Type first number");
int first = readInt();
Console.WriteLine("Type second number");
int second = readInt();

int result = 0;
if(first < second) {
    result = sum(first, second);
} else {
    result = sum(second, first);
}
Console.WriteLine("===>" + result);

int sum(int first, int second) {
    int result = 0;
    while(first < second + 1) {
        result += first;
        first++;
    }
    return result;
}

int readInt() {
    try {
        return int.Parse(Console.ReadLine());
    } catch {
        Console.WriteLine("Incorrect input");
        return 0;
    }
}