﻿Console.WriteLine("Эта программа получает номер дня недели и отвечает является ли он выходным.");
Console.WriteLine("Ниже введите номер дня недели в формате 1,2,3...:");

string? w = Console.ReadLine();
int week = Convert.ToInt32(w);

if (week > 5)
{
    Console.WriteLine ("ДА, это выходной");
}
else
{
    Console.WriteLine("НЕТ, это не выходной");
}