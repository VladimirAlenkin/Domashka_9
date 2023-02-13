// // домашка задача 2
// // Показать натуральные числа от M до N, N и M заданы

void sequence(int max, int min)
{
    if (min > max) return;

    Console.WriteLine(max);
    max = max - 1;
    sequence(max, min);
}
int max;
int min;
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

if (m > n)
{
    max = m;
    min = n;
}
else
{
    max = n;
    min = m;
}
sequence(max, min);

