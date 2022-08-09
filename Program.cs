/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string textNumber = Convert.ToString(number);

if (number > 99) Console.WriteLine(textNumber[2] +" третья цифра числа "+ number);
else Console.WriteLine("третьей цифры нет ");
