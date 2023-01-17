// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите первое число: ");
int a=int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b=int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int c=int.Parse(Console.ReadLine()!);

if (a%2==0)
{
    Console.WriteLine($"Число {a} является четным");
}
else
{
    Console.WriteLine($"Число {a} является нечетным");
}
if (b%2==0)
{
    Console.WriteLine($"Число {b} является четным");
}
else
{
    Console.WriteLine($"Число {b} является нечетным");
}
if (c%2==0)
{
    Console.WriteLine($"Число {c} является четным");
}
else
{
    Console.WriteLine($"Число {c} является нечетным");
}
