// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int InputDigit(string message) // Ввод чисел m и n.
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void CheckNonNegativeAndPrintResult(int m, int n) // Проверка введенных чисел (отрицательное или нет) и вывод результата.
{
    if (m < 0 || n < 0)
    {
        System.Console.Write("Ошибка ввода - отрицательное число.");
        return;
    }
    else
    {
        System.Console.Write($"m = {m}, n = {n} -> A(m,n) = {MethodAckermann(m, n)}");
    }
}

int MethodAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return MethodAckermann(m - 1, 1);
    }
    else
    {
        return MethodAckermann(m - 1, MethodAckermann(m, n - 1));
    }
}

int m = InputDigit("Введите число N: ");
int n = InputDigit("Введите число N: ");

CheckNonNegativeAndPrintResult(m, n);
MethodAckermann(m, n);