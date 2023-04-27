// Задача 66:
// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int InputDigit(string message) // Ввод чисел M и N.
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void CheckNaturalDigitAndPrintResult(int m, int n) // Проверка введенных чисел (натуральное или нет) и вывод результата.
{
    if (m <= 0 || n <= 0)
    {
        System.Console.Write("Ошибка ввода - ненатуральное число.");
        return;
    }
    else
    {
        System.Console.Write($"M = {m}; N = {n} -> {SumInterval(m, n)}");
    }
}
// m = 2, n = 3 -> A(m,n) = 9

int SumInterval(int m, int n) // Суммирование чисел в интервале от M до N и от N до M, если M > N.
{
    int sum = 0;
    if (m < n)
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
    else
    {
        for (int i = n; i <= m; i++)
        {
            sum += i;
        }
    }
    return sum;
}

int m = InputDigit("Введите число M: ");
int n = InputDigit("Введите число N: ");

CheckNaturalDigitAndPrintResult(m, n);
SumInterval(m, n);