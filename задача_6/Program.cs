Console.WriteLine("Эта прорамма узнает четное ли введенное число или нет.");
Console.WriteLine("Введите целое число:");

string? a = Console.ReadLine ( );

int intValue1 = Convert.ToInt32( a );

if( intValue1 % 2 ==0 ) Console.WriteLine("Четное");
else Console.WriteLine("Нечетное");

