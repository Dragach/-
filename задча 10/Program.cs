Console.WriteLine("Эта программа показывает цыфру из разряда десятков трехзначного числа");
Console.WriteLine("Введите целое трехзначное число:");

string? a = Console.ReadLine();
int b = Convert.ToInt32(a);

if (b>99)
{
    //основной код
}
else
{
    Console.WriteLine("Ошибка 1: число не соответсвует условиям.");
    Console.WriteLine(" ");
    Console.WriteLine("Введите ТРЕХЗНАЧНОЕ число!");
}