// Задача 68:
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 –> A(m, n) = 9
// m = 3, n = 2 –> A(m, n) = 29

//            Г n + 1                   m = 0           ||  A(0, n) = n + 1
// A(m, n) = <  A(m - 1, 1)             m > 0, n = 0    ||  A(m, 0) = A(m - 1, 1)
//            L A(m - 1, A(m, n - 1))   m > 0, n > 0    ||  A(m, n) = A(m - 1, A(m, n - 1))

Console.WriteLine();
Console.Write("Введите число (m) в диапазоне [0; 4]: ");
int m = Convert.ToInt32(Console.ReadLine());

if (m < 0 || m > 4)
{
    Console.WriteLine();
    Console.WriteLine("Число (m) вне диапазона [0; 4].");
    return;
}

int[] nMaxValues = new int[5] { 2147483646, 24072, 12036, 11, 0 };

Console.Write($"Введите число (n) в диапазоне [0; {nMaxValues[m]}]: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (n < 0 || n > nMaxValues[m])
{
    Console.WriteLine($"Число (n) вне диапазона [0; {nMaxValues[m]}].");
    return;
}

// int m = 2; int n = 3; // –> A(m, n) = 9
// int m = 3; int n = 2; // –> A(m, n) = 29
int result = AckermannFunction(m, n);
Console.WriteLine($"Функция Аккермана A(m, n) для A({m}, {n}) = {result}.");

int AckermannFunction(int m, int n)
{
    while (m != 0) // Условие выхода из рекурсии: m == 0
    {
        if (n == 0) n = 1; // m > 0 && n == 0
        else n = AckermannFunction(m, n - 1); // m > 0 && n > 0
        m--;
    }
    return n + 1; // Место выхода из рекурсии.
}
