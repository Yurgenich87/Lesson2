/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);

if (stringNumber.Length > 2)
{
	Console.WriteLine("Третья цифра = " + stringNumber[2]);
}
else
{
	Console.WriteLine("Третьей цифры нет!!!");
}


