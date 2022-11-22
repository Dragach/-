Console.WriteLine("Эта программа показывает цыфру из разряда десятков трехзначного числа");
Console.WriteLine("Введите целое трехзначное число:");

string a = Console.ReadLine()!;

if ( a.Length !=3)
{
    Console.WriteLine("Ошибка 1: число не соответсвует условиям.");
    Console.WriteLine(" ");
    Console.WriteLine("Введите ТРЕХЗНАЧНОЕ число!");
}
else
{
    Console.WriteLine("Число из разряда десятков:");
    Console.WriteLine(a[1]);

}