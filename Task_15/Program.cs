﻿/*Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите номер дня: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay == 6 || numberDay == 7)
{
	Console.WriteLine("Выходной день ");
}
else if (numberDay < 1 || numberDay > 7)
{
	Console.WriteLine("Не верно введен номер дня");
}
else
{
	Console.WriteLine("Не выходной день ");
}

