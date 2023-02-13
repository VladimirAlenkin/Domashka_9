// домашка задача 1
// Показать натуральные числа от N до 1, N задано

void sequence(int n)
{   
    if (n == 0) return;
    Console.WriteLine(n);
    sequence(n - 1);
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
sequence(N);
