
Console.WriteLine("Type first number");
int first = readInt();
Console.WriteLine("Type second number");
int second = readInt();

int result = ack(first, second);

Console.WriteLine("===>" + result);

int ack(int n, int m) {
    if (n == 0) {
        return m + 1;
    } else if (m == 0) {
        return ack(n -1, 1);
    }
    return ack(n - 1, ack (n, m - 1));
}

int readInt() {
    try {
        return int.Parse(Console.ReadLine());
    } catch {
        Console.WriteLine("Incorrect input");
        return 0;
    }
}