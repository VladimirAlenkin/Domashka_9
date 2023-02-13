// // домашка задача 4
// // Написать программу вычисления функции Аккермана

int AkkFun (int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AkkFun(m - 1, 1);
    if (m > 0 && n > 0) return AkkFun(m - 1, AkkFun(m, n - 1));
return AkkFun(m, n);
}

Console.WriteLine("Введите параметр m числа A:");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите параметр n числа A");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Функция Аккермана для A (" + m + ", " + n + ") - равна ");
Console.Write (AkkFun(m, n));


