﻿// Программа которая выдает нечетное или четное ли введенное число
Console.Write("Введите число/ ");
int num = Convert.ToInt32(Console.ReadLine());
if(num%2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}