﻿/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int x = number.Length;

if (x == 5)
{
 if (number[0] == number[4] && number[1] == number[3])
    {
 Console.WriteLine($"{number} - палиндром");
    }
 else
    {
 Console.WriteLine($"{number} - не палиндром");
    }
}
else
{
 Console.WriteLine($"{number} - не пятизначное число");
}
