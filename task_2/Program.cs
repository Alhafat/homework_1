// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Введите первое число: ");
// int a=int.Parse(Console.ReadLine()!);

// Console.Write("Введите второе число: ");
// int b=int.Parse(Console.ReadLine()!);

// Console.Write("Введите третье число: ");
// int c=int.Parse(Console.ReadLine()!);

while (true)
{
    Console.Write("Введите первое число: ");
    int a=int.Parse(Console.ReadLine()!);

    Console.Write("Введите второе число: ");
    int b=int.Parse(Console.ReadLine()!);

    if (a!=b)
    {
        Console.Write("Введите третье число: ");
        int c=int.Parse(Console.ReadLine()!);
    }
    else
    {
        if ((b!=c)&(a!=c))
            {
                if ((a>b)&(a>c))
                {
                    Console.WriteLine($"Максимальное число {a}");
                }
                else
                {
                    if (b>c)
                    {
                        Console.WriteLine($"Максимальное число {b}");
                    }
                    else
                    {
                        Console.WriteLine($"Максимальное число {c}");
                    }
                }
            }
        else
        {
            Console.WriteLine($"Введите неравные числа!!!");
            continue;   
        }
    }
break;
}
