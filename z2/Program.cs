﻿Console.Clear();

Console.WriteLine("Введите первое число:");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");

int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    Console.WriteLine($"max = {a}");
    else if (b > a)
    Console.WriteLine($"max = {b}");
    else
        Console.WriteLine("Значения равны");
