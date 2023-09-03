// Задача 66:
// Задайте значения M и N.
// Напишите программу, которая
// найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.
// M = 1; N = 15 –> 120
// M = 4; N =  8 –>  30

Console.WriteLine();
Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (numberM < 1 || numberN < 1)
{
    Console.WriteLine("Одно из чисел или оба не натуральные.");
    return;
}

Console.Write($"Сумма натуральных элементов в промежутке от {numberM} до {numberN}: ");

if (numberN < numberM)
{
    (numberM, numberN) = (numberN, numberM);
}

int result = SumNaturalNumbers(numberM, numberN);
Console.WriteLine(result);

int SumNaturalNumbers(int numM, int numN)
{
    if (numM == numN) return numM; // Условие выхода из рекурсии: numM == numN
    return numM + SumNaturalNumbers(numM + 1, numN);
}
