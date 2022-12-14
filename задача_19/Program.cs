Console.WriteLine("Эта программа получает на вход пятизначное число и проверяет является ли оно палиндромом");
Console.WriteLine("Введите 5-ти значное число");

string number = Console.ReadLine()!;

if ( number.Length == 5 )
{
    if ( number[0] == number[4] && number[1] == number[3] )
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Число не соответсвует условиям");
    Console.WriteLine(" ");
    Console.WriteLine("Введите 5-ти значное число!");
}