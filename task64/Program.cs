
int number = readInt();
printRec(number);

void printRec(int number) {
    if (number <= 0 ) {
        return;
    }
    if (number == 1) {
        Console.Write(number);
    } else {
        Console.Write(number + ", ");
    }
    printRec(number-1);
}

int readInt() {
    try {
        return int.Parse(Console.ReadLine());
    } catch {
        Console.WriteLine("Incorrect input");
        return 0;
    }
}