// Задача 64:
// Задайте значение N.
// Напишите программу, которая
// выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 –> 5, 4, 3, 2, 1
// N = 8 –> 8, 7, 6, 5, 4, 3, 2, 1

Console.WriteLine();
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1)
{
    Console.WriteLine("Число не натуральное.");
    return;
}

Console.Write($"Все натуральные числа в промежутке от {number} до 1: ");
NaturalNumbersDescending(number);
Console.WriteLine();

void NaturalNumbersDescending(int num)
{
    if(num == 1) // Условие выхода из рекурсии: num == 1
    {
        Console.Write($"{num}.");
        return;
    }
    Console.Write($"{num}, ");
    NaturalNumbersDescending(num - 1);
}
