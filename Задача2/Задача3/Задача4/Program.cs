﻿// Напишите программу, которая на вход принимает число(N),
// а на выходе показывает все четные числа от 1 до N 

// 5 -> 2,4
// 8 -> 2,4,6,8

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberB = 2;
if(number > 1)
{
while(numberB <= number)
{
Console.WriteLine(numberB + " ");
numberB = numberB + 2;
}
}
