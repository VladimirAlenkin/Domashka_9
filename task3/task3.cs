// // домашка задача 3
// // Найти сумму элементов от M до N, N и M заданы

void amount(int max, int min, int sum)
{    
    if (min > max)
    {
        Console.WriteLine(sum);
        return;
    }
    sum = sum + min;
    min = min + 1;
    amount(max, min, sum);
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
int sum = 0;
Console.Write("Сумма элементов от " + min + " до " + max + " равна: ");
amount(max, min, sum);


