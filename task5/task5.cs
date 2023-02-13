// // домашка задача 5
// // Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем



void Fibonachi(int m, int k, int sum, int count, int N)
{
    sum = m + k;
    m = k;
    k = sum;
    if (count < N)
    {
        Console.Write(", ");
        Console.Write(sum);
        count++;
    }
    else 
    return;
    Fibonachi(m, k, sum, count, N);
}

Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int k = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество элементов: ");
int N = int.Parse(Console.ReadLine()!);
int sum = 0;
int count = 2;
Console.Write("Последовательность: ");
Console.Write(m + ", " + k);
// Console.Write(k);
Fibonachi(m, k, sum, count, N);



